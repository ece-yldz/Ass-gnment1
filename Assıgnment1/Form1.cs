using System.IO;
namespace Assıgnment1
{
    public partial class frmToDoList : Form
    {
        public frmToDoList()
        {
            InitializeComponent();
            this.Load += frmToDoList_Load; // Load olayını bağla
            this.FormClosing += frmToDoList_FormClosing; // FormClosing olayını bağla
            lstTasks.DrawMode = DrawMode.OwnerDrawFixed; // Öğeleri elle çizmek için
            lstTasks.ItemHeight = 30; // Öğelerin yüksekliğini ayarla
            lstTasks.DrawItem += lstTasks_DrawItem; // DrawItem olayını bağla
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null)
            {
                string selectedTask = lstTasks.SelectedItem.ToString();
                txtTask.Text = selectedTask; // Seçilen görevi TextBox'a getir
                lstTasks.Items.Remove(lstTasks.SelectedItem); // Listeden sil
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTask.Text) && txtTask.Text != "(Empty)")
            {
                string taskText = txtTask.Text;

                // Önceliği belirle
                string priority = "Low"; // Varsayılan öncelik

                if (rbtnHighPriority.Checked)
                {
                    priority = "High";
                    taskText = "High: " + taskText; // Yüksek öncelik
                }
                else if (rbtnMediumPriority.Checked)
                {
                    priority = "Medium";
                    taskText = "Medium: " + taskText; // Orta öncelik
                }
                else if (rbtnLowPriority.Checked)
                {
                    priority = "Low";
                    taskText = "Low: " + taskText; // Düşük öncelik
                }

                lstTasks.Items.Add(taskText); // ListBox'a ekle
                txtTask.Clear(); // TextBox'ı temizle
                UpdateTotalTasks(); // Görev sayısını güncelle
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null)
            {
                lstTasks.Items.Remove(lstTasks.SelectedItem);
                UpdateTotalTasks();
            }
        }

        private void btnMarkComplete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null)
            {
                string selectedTask = lstTasks.SelectedItem.ToString();
                lstTasks.Items[lstTasks.SelectedIndex] = "✔ " + selectedTask; // Başına ✔ işareti ekle
                UpdateTotalTasks();
            }
        }


        private void UpdateTotalTasks()
        {
            lblTotalTasks.Text = $"Total Tasks: {lstTasks.Items.Count}";
        }

        private void SaveTasks()
        {
            // Dosya yolunu belirle
            string filePath = "tasks.txt";

            // Dosyayı aç ve yazma işlemini başlat
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var item in lstTasks.Items)
                {
                    sw.WriteLine(item); // ListBox'taki her öğeyi yaz
                }
            }
        }

        private void LoadTasks()
        {
            string filePath = "tasks.txt";

            // Eğer dosya varsa, dosyayı oku ve ListBox'a ekle
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    // Dosyadaki her satırı oku
                    while ((line = sr.ReadLine()) != null)
                    {
                        lstTasks.Items.Add(line); // Her satırı ListBox'a ekle
                    }
                }
            }
        }

        private void frmToDoList_Load(object sender, EventArgs e)
        {
            LoadTasks(); // Görevleri yükle
            chkDarkMode.Checked = Properties.Settings.Default.IsDarkMode; // Son temasını yükle
            chkDarkMode.CheckedChanged += chkDarkMode_CheckedChanged; // Tema geçişi için olay işleyici
            ApplyTheme();
        }

        private void frmToDoList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.IsDarkMode = chkDarkMode.Checked; // Dark Mode tercihini kaydet
            Properties.Settings.Default.Save();
            SaveTasks(); // Görevleri kaydet

        }

        private void lstTasks_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground(); // Arka plan rengini çiz
            string taskText = lstTasks.Items[e.Index].ToString();

            // Öğeyi seçildiğinde vurgulamak
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(Brushes.LightBlue, e.Bounds); // Seçili öğe için arka plan
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.White, e.Bounds); // Seçili değilse beyaz arka plan
            }

            // Önceliğe göre yazı rengini belirleme
            if (taskText.StartsWith("High")) // High priority
            {
                e.Graphics.DrawString(taskText, e.Font, Brushes.Red, e.Bounds); // Kırmızı renk
            }
            else if (taskText.StartsWith("Medium")) // Medium priority
            {
                e.Graphics.DrawString(taskText, e.Font, Brushes.Blue, e.Bounds); // Mavi renk
            }
            else if (taskText.StartsWith("Low")) // Low priority
            {
                e.Graphics.DrawString(taskText, e.Font, Brushes.Green, e.Bounds); // Yeşil renk
            }
            else
            {
                e.Graphics.DrawString(taskText, e.Font, Brushes.Black, e.Bounds); // Varsayılan siyah renk
            }

            e.DrawFocusRectangle(); // Seçili öğe için odak çerçevesini çiz
        }




        private void chkDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            ApplyTheme(); // Tema geçişini uygula
        }
        private void ApplyTheme()
        {
            if (chkDarkMode.Checked)
            {
                // Dark Mode
                this.BackColor = Color.DimGray;
                lblTotalTasks.ForeColor = Color.White;
                txtTask.BackColor = Color.DarkSlateGray;
                txtTask.ForeColor = Color.White;
                lstTasks.BackColor = Color.DarkSlateGray;
                lstTasks.ForeColor = Color.White;

                SetButtonStyle(Color.Gray, Color.White); // Butonların renklerini güncelle
            }
            else
            {
                // Light Mode
                this.BackColor = Color.LightGray;
                lblTotalTasks.ForeColor = Color.Black;
                txtTask.BackColor = Color.WhiteSmoke;
                txtTask.ForeColor = Color.Black;
                lstTasks.BackColor = Color.WhiteSmoke;
                lstTasks.ForeColor = Color.Black;

                SetButtonStyle(Color.LightSlateGray, Color.Black); // Butonların renklerini güncelle
            }
        }
        private void SetButtonStyle(Color backgroundColor, Color textColor)
        {
            btnAdd.BackColor = backgroundColor;
            btnAdd.ForeColor = textColor;

            btnEdit.BackColor = backgroundColor;
            btnEdit.ForeColor = textColor;

            btnDelete.BackColor = backgroundColor;
            btnDelete.ForeColor = textColor;

            btnMarkComplete.BackColor = backgroundColor;
            btnMarkComplete.ForeColor = textColor;
        }


        private void frmToDoList_Load_1(object sender, EventArgs e)
        {

        }
    }
}

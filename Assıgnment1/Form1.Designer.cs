namespace Assıgnment1
{
    partial class frmToDoList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtTask = new TextBox();
            btnAdd = new Button();
            lstTasks = new ListBox();
            btnEdit = new Button();
            btnDelete = new Button();
            btnMarkComplete = new Button();
            lblTotalTasks = new Label();
            rbtnHighPriority = new RadioButton();
            rbtnMediumPriority = new RadioButton();
            rbtnLowPriority = new RadioButton();
            chkDarkMode = new CheckBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(125, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(118, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "To-Do List ";
            // 
            // txtTask
            // 
            txtTask.BackColor = Color.LightSteelBlue;
            txtTask.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtTask.ForeColor = Color.White;
            txtTask.Location = new Point(20, 50);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(320, 29);
            txtTask.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdd.ForeColor = Color.LightGreen;
            btnAdd.Location = new Point(350, 50);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 30);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Task ";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstTasks
            // 
            lstTasks.BackColor = Color.LightSteelBlue;
            lstTasks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lstTasks.ForeColor = Color.White;
            lstTasks.FormattingEnabled = true;
            lstTasks.ItemHeight = 21;
            lstTasks.Location = new Point(20, 90);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(450, 193);
            lstTasks.TabIndex = 3;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEdit.ForeColor = Color.LightBlue;
            btnEdit.Location = new Point(20, 300);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(140, 30);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit Task ";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDelete.ForeColor = Color.LightCoral;
            btnDelete.Location = new Point(180, 300);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 30);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete Task ";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnMarkComplete
            // 
            btnMarkComplete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMarkComplete.ForeColor = Color.Orange;
            btnMarkComplete.Location = new Point(340, 300);
            btnMarkComplete.Name = "btnMarkComplete";
            btnMarkComplete.Size = new Size(180, 30);
            btnMarkComplete.TabIndex = 6;
            btnMarkComplete.Text = "Mark Completed";
            btnMarkComplete.UseVisualStyleBackColor = true;
            btnMarkComplete.Click += btnMarkComplete_Click;
            // 
            // lblTotalTasks
            // 
            lblTotalTasks.AutoSize = true;
            lblTotalTasks.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTotalTasks.ForeColor = Color.DarkBlue;
            lblTotalTasks.Location = new Point(20, 340);
            lblTotalTasks.Name = "lblTotalTasks";
            lblTotalTasks.Size = new Size(67, 42);
            lblTotalTasks.TabIndex = 7;
            lblTotalTasks.Text = "Total\r\nTasks: 0\r\n";
            // 
            // rbtnHighPriority
            // 
            rbtnHighPriority.AutoSize = true;
            rbtnHighPriority.ForeColor = Color.Red;
            rbtnHighPriority.Location = new Point(115, 363);
            rbtnHighPriority.Name = "rbtnHighPriority";
            rbtnHighPriority.Size = new Size(92, 19);
            rbtnHighPriority.TabIndex = 8;
            rbtnHighPriority.TabStop = true;
            rbtnHighPriority.Text = "High Priority";
            rbtnHighPriority.UseVisualStyleBackColor = true;
            // 
            // rbtnMediumPriority
            // 
            rbtnMediumPriority.AutoSize = true;
            rbtnMediumPriority.ForeColor = Color.Blue;
            rbtnMediumPriority.Location = new Point(213, 363);
            rbtnMediumPriority.Name = "rbtnMediumPriority";
            rbtnMediumPriority.Size = new Size(111, 19);
            rbtnMediumPriority.TabIndex = 9;
            rbtnMediumPriority.TabStop = true;
            rbtnMediumPriority.Text = "Medium Priority";
            rbtnMediumPriority.UseVisualStyleBackColor = true;
            // 
            // rbtnLowPriority
            // 
            rbtnLowPriority.AutoSize = true;
            rbtnLowPriority.ForeColor = Color.Green;
            rbtnLowPriority.Location = new Point(340, 363);
            rbtnLowPriority.Name = "rbtnLowPriority";
            rbtnLowPriority.Size = new Size(88, 19);
            rbtnLowPriority.TabIndex = 10;
            rbtnLowPriority.TabStop = true;
            rbtnLowPriority.Text = "Low Priority";
            rbtnLowPriority.UseVisualStyleBackColor = true;
            // 
            // chkDarkMode
            // 
            chkDarkMode.AutoSize = true;
            chkDarkMode.Location = new Point(0, 0);
            chkDarkMode.Name = "chkDarkMode";
            chkDarkMode.Size = new Size(75, 19);
            chkDarkMode.TabIndex = 11;
            chkDarkMode.Text = "DarkMod";
            chkDarkMode.UseVisualStyleBackColor = true;
            // 
            // frmToDoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(484, 411);
            Controls.Add(chkDarkMode);
            Controls.Add(rbtnLowPriority);
            Controls.Add(rbtnMediumPriority);
            Controls.Add(rbtnHighPriority);
            Controls.Add(lblTotalTasks);
            Controls.Add(btnMarkComplete);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(lstTasks);
            Controls.Add(btnAdd);
            Controls.Add(txtTask);
            Controls.Add(lblTitle);
            Name = "frmToDoList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "To-Do List Application";
            Load += frmToDoList_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtTask;
        private Button btnAdd;
        private ListBox lstTasks;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnMarkComplete;
        private Label lblTotalTasks;
        private RadioButton rbtnHighPriority;
        private RadioButton rbtnMediumPriority;
        private RadioButton rbtnLowPriority;
        private CheckBox chkDarkMode;
    }
}

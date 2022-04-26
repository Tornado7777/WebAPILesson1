namespace EmployeeDirectory
{
    partial class MainView
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
            this.employesDataGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employesDataGridView
            // 
            this.employesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.NameColumn,
            this.SurnameColumn});
            this.employesDataGridView.Location = new System.Drawing.Point(31, 173);
            this.employesDataGridView.MultiSelect = false;
            this.employesDataGridView.Name = "employesDataGridView";
            this.employesDataGridView.RowHeadersWidth = 82;
            this.employesDataGridView.RowTemplate.Height = 41;
            this.employesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employesDataGridView.Size = new System.Drawing.Size(706, 519);
            this.employesDataGridView.TabIndex = 0;
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "#";
            this.IdColumn.MinimumWidth = 10;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Width = 200;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "Имя";
            this.NameColumn.MinimumWidth = 10;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Width = 200;
            // 
            // SurnameColumn
            // 
            this.SurnameColumn.DataPropertyName = "Surname";
            this.SurnameColumn.HeaderText = "Фамилия";
            this.SurnameColumn.MinimumWidth = 10;
            this.SurnameColumn.Name = "SurnameColumn";
            this.SurnameColumn.Width = 200;
            // 
            // LoadButton
            // 
            this.LoadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadButton.Location = new System.Drawing.Point(477, 26);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(260, 115);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Загрузить";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 729);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.employesDataGridView);
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "MainView";
            this.Text = "Справочник сотрудников";
            ((System.ComponentModel.ISupportInitialize)(this.employesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employesDataGridView;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn;
    }
}

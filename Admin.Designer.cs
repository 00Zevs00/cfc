namespace Курсова12
{
    partial class Admin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BD = new System.Windows.Forms.Button();
            this.Vuvod_BD = new System.Windows.Forms.DataGridView();
            this.Dobavut = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Vuvod_BD)).BeginInit();
            this.SuspendLayout();
            // 
            // BD
            // 
            this.BD.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BD.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BD.Location = new System.Drawing.Point(623, 55);
            this.BD.Name = "BD";
            this.BD.Size = new System.Drawing.Size(151, 33);
            this.BD.TabIndex = 7;
            this.BD.Text = "Загрузить БД";
            this.BD.UseVisualStyleBackColor = false;
            this.BD.Click += new System.EventHandler(this.BD_Click);
            this.BD.MouseEnter += new System.EventHandler(this.BD_MouseEnter);
            this.BD.MouseLeave += new System.EventHandler(this.BD_MouseLeave);
            // 
            // Vuvod_BD
            // 
            this.Vuvod_BD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Vuvod_BD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.stan,
            this.cina});
            this.Vuvod_BD.Location = new System.Drawing.Point(12, 12);
            this.Vuvod_BD.Name = "Vuvod_BD";
            this.Vuvod_BD.Size = new System.Drawing.Size(578, 198);
            this.Vuvod_BD.TabIndex = 8;
            // 
            // Dobavut
            // 
            this.Dobavut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dobavut.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dobavut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dobavut.Location = new System.Drawing.Point(623, 94);
            this.Dobavut.Name = "Dobavut";
            this.Dobavut.Size = new System.Drawing.Size(151, 33);
            this.Dobavut.TabIndex = 9;
            this.Dobavut.Text = "Добавить";
            this.Dobavut.UseVisualStyleBackColor = false;
            this.Dobavut.Click += new System.EventHandler(this.Dobavut_Click);
            this.Dobavut.MouseEnter += new System.EventHandler(this.Dobavut_MouseEnter);
            this.Dobavut.MouseLeave += new System.EventHandler(this.Dobavut_MouseLeav);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(753, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(21, 20);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Delete.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete.Location = new System.Drawing.Point(623, 133);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(151, 37);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Удалити";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            this.Delete.MouseEnter += new System.EventHandler(this.Delete_MouseEnter);
            this.Delete.MouseLeave += new System.EventHandler(this.Delete_MouseLeave);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Width = 70;
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.Width = 170;
            // 
            // stan
            // 
            this.stan.HeaderText = "stan";
            this.stan.Name = "stan";
            this.stan.Width = 170;
            // 
            // cina
            // 
            this.cina.HeaderText = "cina";
            this.cina.Name = "cina";
            this.cina.Width = 170;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(781, 235);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Dobavut);
            this.Controls.Add(this.Vuvod_BD);
            this.Controls.Add(this.BD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Vuvod_BD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BD;
        private System.Windows.Forms.DataGridView Vuvod_BD;
        private System.Windows.Forms.Button Dobavut;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn stan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cina;
    }
}


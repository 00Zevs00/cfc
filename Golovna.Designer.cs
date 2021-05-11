namespace Курсова12
{
    partial class Golovna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Vuvod_BD = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginADM = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Label();
            this.BD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Vuvod_BD)).BeginInit();
            this.SuspendLayout();
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
            this.Vuvod_BD.Size = new System.Drawing.Size(548, 198);
            this.Vuvod_BD.TabIndex = 9;
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
            // 
            // LoginADM
            // 
            this.LoginADM.BackColor = System.Drawing.SystemColors.Desktop;
            this.LoginADM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginADM.ForeColor = System.Drawing.SystemColors.Control;
            this.LoginADM.Location = new System.Drawing.Point(566, 158);
            this.LoginADM.Name = "LoginADM";
            this.LoginADM.Size = new System.Drawing.Size(124, 52);
            this.LoginADM.TabIndex = 11;
            this.LoginADM.Text = "Вхід ADM";
            this.LoginADM.UseVisualStyleBackColor = false;
            this.LoginADM.Click += new System.EventHandler(this.LoginADM_Click);
            this.LoginADM.MouseEnter += new System.EventHandler(this.LoginADM_MouseEnter);
            this.LoginADM.MouseLeave += new System.EventHandler(this.LoginADM_MouseLeave);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(678, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(21, 20);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // BD
            // 
            this.BD.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BD.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BD.Location = new System.Drawing.Point(566, 57);
            this.BD.Name = "BD";
            this.BD.Size = new System.Drawing.Size(124, 49);
            this.BD.TabIndex = 15;
            this.BD.Text = "Загрузить БД";
            this.BD.UseVisualStyleBackColor = false;
            this.BD.Click += new System.EventHandler(this.BD_Click);
            this.BD.MouseEnter += new System.EventHandler(this.BD_MouseEnter);
            this.BD.MouseLeave += new System.EventHandler(this.BD_MouseLeave);
            // 
            // Golovna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 217);
            this.Controls.Add(this.BD);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.LoginADM);
            this.Controls.Add(this.Vuvod_BD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Golovna";
            this.Text = "Form2";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Golovna_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Golovna_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Vuvod_BD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Vuvod_BD;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn stan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cina;
        private System.Windows.Forms.Button LoginADM;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Button BD;
    }
}
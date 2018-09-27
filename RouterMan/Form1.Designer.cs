namespace RouterMan
{
    partial class FormGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGeneral));
            this.dataGridViewKran = new System.Windows.Forms.DataGridView();
            this.textBoxDetailCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.tabControlGeneral = new System.Windows.Forms.TabControl();
            this.tabPageKran = new System.Windows.Forms.TabPage();
            this.tabPageMaz = new System.Windows.Forms.TabPage();
            this.dataGridViewMaz = new System.Windows.Forms.DataGridView();
            this.tabPagePlat = new System.Windows.Forms.TabPage();
            this.dataGridViewPlat = new System.Windows.Forms.DataGridView();
            this.buttonUpdateDataBase = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKran)).BeginInit();
            this.tabControlGeneral.SuspendLayout();
            this.tabPageKran.SuspendLayout();
            this.tabPageMaz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaz)).BeginInit();
            this.tabPagePlat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKran
            // 
            this.dataGridViewKran.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewKran.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewKran.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewKran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewKran.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewKran.Name = "dataGridViewKran";
            this.dataGridViewKran.ReadOnly = true;
            this.dataGridViewKran.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKran.Size = new System.Drawing.Size(1068, 481);
            this.dataGridViewKran.TabIndex = 0;
            // 
            // textBoxDetailCode
            // 
            this.textBoxDetailCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDetailCode.Location = new System.Drawing.Point(175, 11);
            this.textBoxDetailCode.Name = "textBoxDetailCode";
            this.textBoxDetailCode.Size = new System.Drawing.Size(289, 29);
            this.textBoxDetailCode.TabIndex = 1;
            this.textBoxDetailCode.EnabledChanged += new System.EventHandler(this.Search_Click);
            this.textBoxDetailCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Press_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Код детали";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(494, 8);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(157, 37);
            this.Search.TabIndex = 4;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // tabControlGeneral
            // 
            this.tabControlGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlGeneral.Controls.Add(this.tabPageKran);
            this.tabControlGeneral.Controls.Add(this.tabPageMaz);
            this.tabControlGeneral.Controls.Add(this.tabPagePlat);
            this.tabControlGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlGeneral.Location = new System.Drawing.Point(12, 70);
            this.tabControlGeneral.Name = "tabControlGeneral";
            this.tabControlGeneral.SelectedIndex = 0;
            this.tabControlGeneral.Size = new System.Drawing.Size(1088, 522);
            this.tabControlGeneral.TabIndex = 5;
            // 
            // tabPageKran
            // 
            this.tabPageKran.Controls.Add(this.dataGridViewKran);
            this.tabPageKran.Location = new System.Drawing.Point(4, 25);
            this.tabPageKran.Name = "tabPageKran";
            this.tabPageKran.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKran.Size = new System.Drawing.Size(1080, 493);
            this.tabPageKran.TabIndex = 0;
            this.tabPageKran.Text = "Крановая и спец. техника";
            this.tabPageKran.UseVisualStyleBackColor = true;
            // 
            // tabPageMaz
            // 
            this.tabPageMaz.Controls.Add(this.dataGridViewMaz);
            this.tabPageMaz.Location = new System.Drawing.Point(4, 25);
            this.tabPageMaz.Name = "tabPageMaz";
            this.tabPageMaz.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMaz.Size = new System.Drawing.Size(1080, 493);
            this.tabPageMaz.TabIndex = 1;
            this.tabPageMaz.Text = "МАЗы";
            this.tabPageMaz.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMaz
            // 
            this.dataGridViewMaz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMaz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewMaz.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewMaz.Name = "dataGridViewMaz";
            this.dataGridViewMaz.ReadOnly = true;
            this.dataGridViewMaz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMaz.Size = new System.Drawing.Size(1068, 481);
            this.dataGridViewMaz.TabIndex = 0;
            // 
            // tabPagePlat
            // 
            this.tabPagePlat.Controls.Add(this.dataGridViewPlat);
            this.tabPagePlat.Location = new System.Drawing.Point(4, 25);
            this.tabPagePlat.Name = "tabPagePlat";
            this.tabPagePlat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlat.Size = new System.Drawing.Size(1080, 493);
            this.tabPagePlat.TabIndex = 2;
            this.tabPagePlat.Text = "Платформы";
            this.tabPagePlat.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPlat
            // 
            this.dataGridViewPlat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPlat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPlat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewPlat.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewPlat.Name = "dataGridViewPlat";
            this.dataGridViewPlat.ReadOnly = true;
            this.dataGridViewPlat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPlat.Size = new System.Drawing.Size(1068, 481);
            this.dataGridViewPlat.TabIndex = 0;
            // 
            // buttonUpdateDataBase
            // 
            this.buttonUpdateDataBase.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonUpdateDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdateDataBase.Location = new System.Drawing.Point(693, 8);
            this.buttonUpdateDataBase.Name = "buttonUpdateDataBase";
            this.buttonUpdateDataBase.Size = new System.Drawing.Size(157, 56);
            this.buttonUpdateDataBase.TabIndex = 6;
            this.buttonUpdateDataBase.Text = "Обновить бызы данных";
            this.buttonUpdateDataBase.UseVisualStyleBackColor = false;
            this.buttonUpdateDataBase.Click += new System.EventHandler(this.buttonUpdateDataBase_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RouterMan.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(903, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 597);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonUpdateDataBase);
            this.Controls.Add(this.tabControlGeneral);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDetailCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1128, 636);
            this.Name = "FormGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Маршрутчик";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKran)).EndInit();
            this.tabControlGeneral.ResumeLayout(false);
            this.tabPageKran.ResumeLayout(false);
            this.tabPageMaz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaz)).EndInit();
            this.tabPagePlat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKran;
        private System.Windows.Forms.TextBox textBoxDetailCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TabControl tabControlGeneral;
        private System.Windows.Forms.TabPage tabPageKran;
        private System.Windows.Forms.TabPage tabPageMaz;
        private System.Windows.Forms.DataGridView dataGridViewMaz;
        private System.Windows.Forms.TabPage tabPagePlat;
        private System.Windows.Forms.DataGridView dataGridViewPlat;
        private System.Windows.Forms.Button buttonUpdateDataBase;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


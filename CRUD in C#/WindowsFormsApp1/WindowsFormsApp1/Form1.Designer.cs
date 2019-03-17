namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SoldierName = new System.Windows.Forms.TextBox();
            this.SoldierCountry = new System.Windows.Forms.TextBox();
            this.SoldierAlliance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.allSoldiers = new System.Windows.Forms.ListView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.editSoldier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SoldierName
            // 
            this.SoldierName.Location = new System.Drawing.Point(61, 40);
            this.SoldierName.Name = "SoldierName";
            this.SoldierName.Size = new System.Drawing.Size(161, 22);
            this.SoldierName.TabIndex = 0;
            // 
            // SoldierCountry
            // 
            this.SoldierCountry.Location = new System.Drawing.Point(61, 82);
            this.SoldierCountry.Name = "SoldierCountry";
            this.SoldierCountry.Size = new System.Drawing.Size(161, 22);
            this.SoldierCountry.TabIndex = 1;
            // 
            // SoldierAlliance
            // 
            this.SoldierAlliance.Location = new System.Drawing.Point(61, 124);
            this.SoldierAlliance.Name = "SoldierAlliance";
            this.SoldierAlliance.Size = new System.Drawing.Size(161, 22);
            this.SoldierAlliance.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // allSoldiers
            // 
            this.allSoldiers.Location = new System.Drawing.Point(285, 108);
            this.allSoldiers.Name = "allSoldiers";
            this.allSoldiers.Size = new System.Drawing.Size(560, 242);
            this.allSoldiers.TabIndex = 5;
            this.allSoldiers.UseCompatibleStateImageBehavior = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(285, 356);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 52);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // editSoldier
            // 
            this.editSoldier.Location = new System.Drawing.Point(720, 25);
            this.editSoldier.Name = "editSoldier";
            this.editSoldier.Size = new System.Drawing.Size(125, 52);
            this.editSoldier.TabIndex = 7;
            this.editSoldier.Text = "Edit";
            this.editSoldier.UseVisualStyleBackColor = true;
            this.editSoldier.Click += new System.EventHandler(this.editSoldier_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 452);
            this.Controls.Add(this.editSoldier);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.allSoldiers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SoldierAlliance);
            this.Controls.Add(this.SoldierCountry);
            this.Controls.Add(this.SoldierName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SoldierName;
        private System.Windows.Forms.TextBox SoldierCountry;
        private System.Windows.Forms.TextBox SoldierAlliance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView allSoldiers;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button editSoldier;
    }
}


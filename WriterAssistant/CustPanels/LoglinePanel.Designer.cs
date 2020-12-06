using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebNovelAssistant.CustPanels
{
    partial class LogLinePanel
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_randomgenerator = new System.Windows.Forms.Label();
            this.lbl_tip1 = new System.Windows.Forms.Label();
            this.lbl_logline = new System.Windows.Forms.Label();
            this.tb_logline = new System.Windows.Forms.TextBox();
            this.tb_randomLoglines = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_randomgenerator
            // 
            this.lbl_randomgenerator.AutoSize = true;
            this.lbl_randomgenerator.Location = new System.Drawing.Point(19, 131);
            this.lbl_randomgenerator.Name = "lbl_randomgenerator";
            this.lbl_randomgenerator.Size = new System.Drawing.Size(165, 15);
            this.lbl_randomgenerator.TabIndex = 14;
            this.lbl_randomgenerator.Text = "Randomly Generated Loglines";
            // 
            // lbl_tip1
            // 
            this.lbl_tip1.AutoSize = true;
            this.lbl_tip1.Location = new System.Drawing.Point(16, 107);
            this.lbl_tip1.Name = "lbl_tip1";
            this.lbl_tip1.Size = new System.Drawing.Size(356, 15);
            this.lbl_tip1.TabIndex = 10;
            this.lbl_tip1.Text = "Rougly what you think your story will be about in one or two lines.";
            // 
            // lbl_logline
            // 
            this.lbl_logline.AutoSize = true;
            this.lbl_logline.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_logline.Location = new System.Drawing.Point(16, 18);
            this.lbl_logline.Name = "lbl_logline";
            this.lbl_logline.Size = new System.Drawing.Size(103, 21);
            this.lbl_logline.TabIndex = 8;
            this.lbl_logline.Text = "Your logline";
            // 
            // tb_logline
            // 
            this.tb_logline.Location = new System.Drawing.Point(16, 42);
            this.tb_logline.Multiline = true;
            this.tb_logline.Name = "tb_logline";
            this.tb_logline.Size = new System.Drawing.Size(625, 62);
            this.tb_logline.TabIndex = 15;
            // 
            // tb_randomLoglines
            // 
            this.tb_randomLoglines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_randomLoglines.Enabled = false;
            this.tb_randomLoglines.Location = new System.Drawing.Point(16, 148);
            this.tb_randomLoglines.Margin = new System.Windows.Forms.Padding(0);
            this.tb_randomLoglines.Multiline = true;
            this.tb_randomLoglines.Name = "tb_randomLoglines";
            this.tb_randomLoglines.Size = new System.Drawing.Size(625, 807);
            this.tb_randomLoglines.TabIndex = 16;
            this.tb_randomLoglines.Text = "Comming Soon...";
            // 
            // LogLinePanel
            // 
            this.Controls.Add(this.tb_randomLoglines);
            this.Controls.Add(this.tb_logline);
            this.Controls.Add(this.lbl_randomgenerator);
            this.Controls.Add(this.lbl_tip1);
            this.Controls.Add(this.lbl_logline);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LogLinePanel";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1457, 969);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Label lbl_randomgenerator;
        private Label lbl_tip1;
        private TextBox tb_logline;
        private TextBox tb_randomLoglines;
        private Label lbl_logline;
    }
}

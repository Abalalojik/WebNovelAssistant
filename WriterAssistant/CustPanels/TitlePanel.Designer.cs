
namespace WebNovelAssistant.CustPanels
{
    partial class TitlePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitlePanel));
            this.lbl_title = new System.Windows.Forms.Label();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.lbl_tip1 = new System.Windows.Forms.Label();
            this.lbl_TitleType = new System.Windows.Forms.Label();
            this.cb_TitleType = new System.Windows.Forms.ComboBox();
            this.lb_generator = new System.Windows.Forms.ListBox();
            this.lbl_randomgenerator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(5, 5);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(165, 21);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Your Webnovel Title";
            // 
            // tb_title
            // 
            this.tb_title.Location = new System.Drawing.Point(5, 29);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(509, 23);
            this.tb_title.TabIndex = 1;
            // 
            // lbl_tip1
            // 
            this.lbl_tip1.AutoSize = true;
            this.lbl_tip1.Location = new System.Drawing.Point(5, 55);
            this.lbl_tip1.Name = "lbl_tip1";
            this.lbl_tip1.Size = new System.Drawing.Size(625, 45);
            this.lbl_tip1.TabIndex = 3;
            this.lbl_tip1.Text = resources.GetString("lbl_tip1.Text");
            // 
            // lbl_TitleType
            // 
            this.lbl_TitleType.AutoSize = true;
            this.lbl_TitleType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TitleType.Location = new System.Drawing.Point(5, 104);
            this.lbl_TitleType.Name = "lbl_TitleType";
            this.lbl_TitleType.Size = new System.Drawing.Size(104, 21);
            this.lbl_TitleType.TabIndex = 4;
            this.lbl_TitleType.Text = "Type of Title";
            // 
            // cb_TitleType
            // 
            this.cb_TitleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TitleType.FormattingEnabled = true;
            this.cb_TitleType.Items.AddRange(new object[] {
            "Definitive Title",
            "Working Title"});
            this.cb_TitleType.Location = new System.Drawing.Point(5, 128);
            this.cb_TitleType.Name = "cb_TitleType";
            this.cb_TitleType.Size = new System.Drawing.Size(165, 23);
            this.cb_TitleType.Sorted = true;
            this.cb_TitleType.TabIndex = 5;
            // 
            // lb_generator
            // 
            this.lb_generator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_generator.Enabled = false;
            this.lb_generator.FormattingEnabled = true;
            this.lb_generator.ItemHeight = 15;
            this.lb_generator.Items.AddRange(new object[] {
            "Coming Soon..."});
            this.lb_generator.Location = new System.Drawing.Point(5, 188);
            this.lb_generator.Name = "lb_generator";
            this.lb_generator.Size = new System.Drawing.Size(625, 769);
            this.lb_generator.TabIndex = 6;
            // 
            // lbl_randomgenerator
            // 
            this.lbl_randomgenerator.AutoSize = true;
            this.lbl_randomgenerator.Location = new System.Drawing.Point(5, 170);
            this.lbl_randomgenerator.Name = "lbl_randomgenerator";
            this.lbl_randomgenerator.Size = new System.Drawing.Size(158, 15);
            this.lbl_randomgenerator.TabIndex = 7;
            this.lbl_randomgenerator.Text = "Randomly Generated Names";
            // 
            // TitlePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_randomgenerator);
            this.Controls.Add(this.lb_generator);
            this.Controls.Add(this.cb_TitleType);
            this.Controls.Add(this.lbl_TitleType);
            this.Controls.Add(this.lbl_tip1);
            this.Controls.Add(this.tb_title);
            this.Controls.Add(this.lbl_title);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.Name = "TitlePanel";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.Size = new System.Drawing.Size(1457, 969);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.Label lbl_tip1;
        private System.Windows.Forms.Label lbl_TitleType;
        private System.Windows.Forms.ComboBox cb_TitleType;
        private System.Windows.Forms.ListBox lb_generator;
        private System.Windows.Forms.Label lbl_randomgenerator;
    }
}

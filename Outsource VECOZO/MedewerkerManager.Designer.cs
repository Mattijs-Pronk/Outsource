
namespace Outsource_VECOZO
{
    partial class MedewerkerManager
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
            this.dgvMedewerkers = new System.Windows.Forms.DataGridView();
            this.btSearch = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbVaardigheid = new System.Windows.Forms.ComboBox();
            this.cbFunctie = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedewerkers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedewerkers
            // 
            this.dgvMedewerkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedewerkers.Location = new System.Drawing.Point(154, 147);
            this.dgvMedewerkers.Name = "dgvMedewerkers";
            this.dgvMedewerkers.RowHeadersWidth = 51;
            this.dgvMedewerkers.RowTemplate.Height = 29;
            this.dgvMedewerkers.Size = new System.Drawing.Size(755, 494);
            this.dgvMedewerkers.TabIndex = 8;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(586, 112);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(94, 29);
            this.btSearch.TabIndex = 7;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(387, 112);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(193, 27);
            this.tbName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(426, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Medewerkers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(721, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Filter op vaardigheid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(740, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Filter op functie";
            // 
            // cbVaardigheid
            // 
            this.cbVaardigheid.FormattingEnabled = true;
            this.cbVaardigheid.Items.AddRange(new object[] {
            "HTML and CSS",
            "Python",
            "Java",
            "JavaScript",
            "Swift",
            "C++",
            "C#",
            "R"});
            this.cbVaardigheid.Location = new System.Drawing.Point(721, 111);
            this.cbVaardigheid.Name = "cbVaardigheid";
            this.cbVaardigheid.Size = new System.Drawing.Size(151, 28);
            this.cbVaardigheid.TabIndex = 11;
            // 
            // cbFunctie
            // 
            this.cbFunctie.FormattingEnabled = true;
            this.cbFunctie.Items.AddRange(new object[] {
            "Professional Bridesmaid",
            "Water Slide Tester",
            "Paper Towel Sniffer",
            "Face Feeler",
            "Line Stander",
            "Bed Tester",
            "Pet Food Taster"});
            this.cbFunctie.Location = new System.Drawing.Point(721, 57);
            this.cbFunctie.Name = "cbFunctie";
            this.cbFunctie.Size = new System.Drawing.Size(151, 28);
            this.cbFunctie.TabIndex = 10;
            // 
            // MedewerkerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbVaardigheid);
            this.Controls.Add(this.cbFunctie);
            this.Controls.Add(this.dgvMedewerkers);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Name = "MedewerkerManager";
            this.Text = "MedewerkerManager";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedewerkers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMedewerkers;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbVaardigheid;
        private System.Windows.Forms.ComboBox cbFunctie;
    }
}
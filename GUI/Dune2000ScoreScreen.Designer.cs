namespace MissionLauncher
{
    partial class Dune2000ScoreScreen
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
       private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OKButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Player1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewDetailsButton = new System.Windows.Forms.Button();
            this.DontShowAgainCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(837, 447);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Player1,
            this.Player2,
            this.Player3,
            this.Player4,
            this.Player5,
            this.Player6,
            this.Player7,
            this.Player8});
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersWidth = 210;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.Size = new System.Drawing.Size(917, 424);
            this.dataGridView1.TabIndex = 2;
            // 
            // Player1
            // 
            this.Player1.HeaderText = "Atreides";
            this.Player1.Name = "Player1";
            this.Player1.ReadOnly = true;
            this.Player1.Width = 88;
            // 
            // Player2
            // 
            this.Player2.HeaderText = "Harkonnen";
            this.Player2.Name = "Player2";
            this.Player2.ReadOnly = true;
            this.Player2.Width = 88;
            // 
            // Player3
            // 
            this.Player3.HeaderText = "Ordos";
            this.Player3.Name = "Player3";
            this.Player3.ReadOnly = true;
            this.Player3.Width = 88;
            // 
            // Player4
            // 
            this.Player4.HeaderText = "Emperor";
            this.Player4.Name = "Player4";
            this.Player4.ReadOnly = true;
            this.Player4.Width = 89;
            // 
            // Player5
            // 
            this.Player5.HeaderText = "Fremen";
            this.Player5.Name = "Player5";
            this.Player5.ReadOnly = true;
            this.Player5.Width = 88;
            // 
            // Player6
            // 
            this.Player6.HeaderText = "Smugglers";
            this.Player6.Name = "Player6";
            this.Player6.ReadOnly = true;
            this.Player6.Width = 88;
            // 
            // Player7
            // 
            this.Player7.HeaderText = "Mercenaries";
            this.Player7.Name = "Player7";
            this.Player7.ReadOnly = true;
            this.Player7.Width = 88;
            // 
            // Player8
            // 
            this.Player8.HeaderText = "Sandworm";
            this.Player8.Name = "Player8";
            this.Player8.ReadOnly = true;
            this.Player8.Width = 88;
            // 
            // ViewDetailsButton
            // 
            this.ViewDetailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewDetailsButton.Location = new System.Drawing.Point(727, 447);
            this.ViewDetailsButton.Name = "ViewDetailsButton";
            this.ViewDetailsButton.Size = new System.Drawing.Size(104, 23);
            this.ViewDetailsButton.TabIndex = 5;
            this.ViewDetailsButton.Text = "View Details";
            this.ViewDetailsButton.UseVisualStyleBackColor = true;
            this.ViewDetailsButton.Click += new System.EventHandler(this.ViewDetailsButton_Click);
            // 
            // DontShowAgainCheckBox
            // 
            this.DontShowAgainCheckBox.AutoSize = true;
            this.DontShowAgainCheckBox.Location = new System.Drawing.Point(5, 453);
            this.DontShowAgainCheckBox.Name = "DontShowAgainCheckBox";
            this.DontShowAgainCheckBox.Size = new System.Drawing.Size(158, 17);
            this.DontShowAgainCheckBox.TabIndex = 6;
            this.DontShowAgainCheckBox.Text = "Don\'t show this dialog again";
            this.DontShowAgainCheckBox.UseVisualStyleBackColor = true;
            // 
            // Dune2000ScoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 482);
            this.Controls.Add(this.DontShowAgainCheckBox);
            this.Controls.Add(this.ViewDetailsButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.OKButton);
            this.Name = "Dune2000ScoreScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Score Screen";
            this.Load += new System.EventHandler(this.Dune2000ScoreScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ViewDetailsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player8;
        private System.Windows.Forms.CheckBox DontShowAgainCheckBox;
    }
}
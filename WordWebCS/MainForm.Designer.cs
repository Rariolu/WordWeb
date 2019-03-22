namespace WordWebCS
{
    partial class MainForm
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
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.btnDrawGraph = new System.Windows.Forms.Button();
            this.btnProcessText = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbMain = new System.Windows.Forms.RichTextBox();
            this.btnReprocess = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnWikiText = new System.Windows.Forms.Button();
            this.pnlOptions.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.btnWikiText);
            this.pnlOptions.Controls.Add(this.button1);
            this.pnlOptions.Controls.Add(this.btnReprocess);
            this.pnlOptions.Controls.Add(this.btnDrawGraph);
            this.pnlOptions.Controls.Add(this.btnProcessText);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOptions.Location = new System.Drawing.Point(0, 289);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(729, 100);
            this.pnlOptions.TabIndex = 0;
            // 
            // btnDrawGraph
            // 
            this.btnDrawGraph.Location = new System.Drawing.Point(190, 45);
            this.btnDrawGraph.Name = "btnDrawGraph";
            this.btnDrawGraph.Size = new System.Drawing.Size(75, 23);
            this.btnDrawGraph.TabIndex = 1;
            this.btnDrawGraph.Text = "Draw Graph";
            this.btnDrawGraph.UseVisualStyleBackColor = true;
            this.btnDrawGraph.Click += new System.EventHandler(this.btnDrawGraph_Click);
            // 
            // btnProcessText
            // 
            this.btnProcessText.Location = new System.Drawing.Point(60, 40);
            this.btnProcessText.Name = "btnProcessText";
            this.btnProcessText.Size = new System.Drawing.Size(98, 28);
            this.btnProcessText.TabIndex = 0;
            this.btnProcessText.Text = "Process Text";
            this.btnProcessText.UseVisualStyleBackColor = true;
            this.btnProcessText.Click += new System.EventHandler(this.btnProcessText_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtbMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 289);
            this.panel2.TabIndex = 1;
            // 
            // rtbMain
            // 
            this.rtbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMain.Location = new System.Drawing.Point(0, 0);
            this.rtbMain.Name = "rtbMain";
            this.rtbMain.Size = new System.Drawing.Size(729, 289);
            this.rtbMain.TabIndex = 0;
            this.rtbMain.Text = "";
            this.rtbMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbMain_KeyDown);
            // 
            // btnReprocess
            // 
            this.btnReprocess.Location = new System.Drawing.Point(348, 45);
            this.btnReprocess.Name = "btnReprocess";
            this.btnReprocess.Size = new System.Drawing.Size(75, 23);
            this.btnReprocess.TabIndex = 2;
            this.btnReprocess.Text = "ReProcess";
            this.btnReprocess.UseVisualStyleBackColor = true;
            this.btnReprocess.Click += new System.EventHandler(this.btnReprocess_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnWikiText
            // 
            this.btnWikiText.Location = new System.Drawing.Point(463, 34);
            this.btnWikiText.Name = "btnWikiText";
            this.btnWikiText.Size = new System.Drawing.Size(75, 23);
            this.btnWikiText.TabIndex = 4;
            this.btnWikiText.Text = "button2";
            this.btnWikiText.UseVisualStyleBackColor = true;
            this.btnWikiText.Click += new System.EventHandler(this.btnWikiText_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 389);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlOptions);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.pnlOptions.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtbMain;
        private System.Windows.Forms.Button btnProcessText;
        private System.Windows.Forms.Button btnDrawGraph;
        private System.Windows.Forms.Button btnReprocess;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnWikiText;
    }
}


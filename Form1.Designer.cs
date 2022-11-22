
namespace unit_2
{
    partial class Form1
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
            this.btnNumNames = new System.Windows.Forms.Button();
            this.btnGetNames = new System.Windows.Forms.Button();
            this.lblMessages = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNumNames
            // 
            this.btnNumNames.Location = new System.Drawing.Point(160, 316);
            this.btnNumNames.Name = "btnNumNames";
            this.btnNumNames.Size = new System.Drawing.Size(102, 46);
            this.btnNumNames.TabIndex = 0;
            this.btnNumNames.Text = "Get Number of Names";
            this.btnNumNames.UseVisualStyleBackColor = true;
            this.btnNumNames.Click += new System.EventHandler(this.btnNumNames_Click_1);
            // 
            // btnGetNames
            // 
            this.btnGetNames.Location = new System.Drawing.Point(572, 316);
            this.btnGetNames.Name = "btnGetNames";
            this.btnGetNames.Size = new System.Drawing.Size(88, 46);
            this.btnGetNames.TabIndex = 1;
            this.btnGetNames.Text = "Get names";
            this.btnGetNames.UseVisualStyleBackColor = true;
            this.btnGetNames.Click += new System.EventHandler(this.btnGetNames_Click);
            // 
            // lblMessages
            // 
            this.lblMessages.AutoSize = true;
            this.lblMessages.Location = new System.Drawing.Point(157, 83);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(61, 13);
            this.lblMessages.TabIndex = 2;
            this.lblMessages.Text = "Nothing yet";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(506, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.btnGetNames);
            this.Controls.Add(this.btnNumNames);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNumNames;
        private System.Windows.Forms.Button btnGetNames;
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


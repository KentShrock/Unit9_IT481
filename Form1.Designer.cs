
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
            this.radCust = new System.Windows.Forms.RadioButton();
            this.radOrders = new System.Windows.Forms.RadioButton();
            this.radEmp = new System.Windows.Forms.RadioButton();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNumNames
            // 
            this.btnNumNames.Location = new System.Drawing.Point(686, 392);
            this.btnNumNames.Name = "btnNumNames";
            this.btnNumNames.Size = new System.Drawing.Size(102, 46);
            this.btnNumNames.TabIndex = 0;
            this.btnNumNames.Text = "Get Number of Names";
            this.btnNumNames.UseVisualStyleBackColor = true;
            this.btnNumNames.Click += new System.EventHandler(this.btnNumNames_Click_1);
            // 
            // btnGetNames
            // 
            this.btnGetNames.Location = new System.Drawing.Point(686, 323);
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
            this.lblMessages.Location = new System.Drawing.Point(12, 34);
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
            // radCust
            // 
            this.radCust.AutoSize = true;
            this.radCust.Location = new System.Drawing.Point(28, 166);
            this.radCust.Name = "radCust";
            this.radCust.Size = new System.Drawing.Size(100, 17);
            this.radCust.TabIndex = 4;
            this.radCust.TabStop = true;
            this.radCust.Text = "Customers table";
            this.radCust.UseVisualStyleBackColor = true;
            // 
            // radOrders
            // 
            this.radOrders.AutoSize = true;
            this.radOrders.Location = new System.Drawing.Point(28, 190);
            this.radOrders.Name = "radOrders";
            this.radOrders.Size = new System.Drawing.Size(82, 17);
            this.radOrders.TabIndex = 5;
            this.radOrders.TabStop = true;
            this.radOrders.Text = "Orders table";
            this.radOrders.UseVisualStyleBackColor = true;
            // 
            // radEmp
            // 
            this.radEmp.AutoSize = true;
            this.radEmp.Location = new System.Drawing.Point(28, 214);
            this.radEmp.Name = "radEmp";
            this.radEmp.Size = new System.Drawing.Size(97, 17);
            this.radEmp.TabIndex = 6;
            this.radEmp.TabStop = true;
            this.radEmp.Text = "Employee table";
            this.radEmp.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(28, 237);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(126, 23);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "View selected table";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.radEmp);
            this.Controls.Add(this.radOrders);
            this.Controls.Add(this.radCust);
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
        private System.Windows.Forms.RadioButton radCust;
        private System.Windows.Forms.RadioButton radOrders;
        private System.Windows.Forms.RadioButton radEmp;
        private System.Windows.Forms.Button btnView;
    }
}


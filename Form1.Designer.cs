namespace WindowsFormsApplication1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_flip = new System.Windows.Forms.Button();
            this.btn_normal = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Device = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_flip, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_normal, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(490, 362);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_flip
            // 
            this.btn_flip.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_flip.Location = new System.Drawing.Point(3, 3);
            this.btn_flip.Name = "btn_flip";
            this.btn_flip.Size = new System.Drawing.Size(239, 23);
            this.btn_flip.TabIndex = 0;
            this.btn_flip.Text = "Flip";
            this.btn_flip.UseVisualStyleBackColor = true;
            this.btn_flip.Click += new System.EventHandler(this.btn_flip_Click);
            // 
            // btn_normal
            // 
            this.btn_normal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_normal.Location = new System.Drawing.Point(248, 3);
            this.btn_normal.Name = "btn_normal";
            this.btn_normal.Size = new System.Drawing.Size(239, 23);
            this.btn_normal.TabIndex = 1;
            this.btn_normal.Text = "Normal";
            this.btn_normal.UseVisualStyleBackColor = true;
            this.btn_normal.Click += new System.EventHandler(this.btn_normal_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Device,
            this.columnHeader2});
            this.tableLayoutPanel1.SetColumnSpan(this.listView1, 2);
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 32);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(484, 327);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Device
            // 
            this.Device.Text = "Device";
            this.Device.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "State";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Please Remove usb mice and then plug them back in";
            this.notifyIcon1.BalloonTipTitle = "Mousewheel Setting Successful.";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 362);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Flip Mouse Wheel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_flip;
        private System.Windows.Forms.Button btn_normal;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Device;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}


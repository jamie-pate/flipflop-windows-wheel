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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_showAll = new System.Windows.Forms.Button();
            this.dgv_flippable = new System.Windows.Forms.DataGridView();
            this.btn_flip = new System.Windows.Forms.Button();
            this.btn_normal = new System.Windows.Forms.Button();
            this.tmr_popup = new System.Windows.Forms.Timer(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verticalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.horizontalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.flippableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_flippable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flippableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Please Remove usb mice and then plug them back in";
            this.notifyIcon1.BalloonTipTitle = "Mousewheel Setting Successful.";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btn_showAll, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_flippable, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_flip, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_normal, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(599, 529);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_showAll
            // 
            this.btn_showAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_showAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_showAll.Image = ((System.Drawing.Image)(resources.GetObject("btn_showAll.Image")));
            this.btn_showAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_showAll.Location = new System.Drawing.Point(394, 3);
            this.btn_showAll.Name = "btn_showAll";
            this.btn_showAll.Size = new System.Drawing.Size(191, 23);
            this.btn_showAll.TabIndex = 3;
            this.btn_showAll.Text = "Show All";
            this.btn_showAll.UseVisualStyleBackColor = true;
            this.btn_showAll.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_flippable
            // 
            this.dgv_flippable.AutoGenerateColumns = false;
            this.dgv_flippable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.verticalDataGridViewTextBoxColumn,
            this.horizontalDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dgv_flippable, 4);
            this.dgv_flippable.DataSource = this.flippableBindingSource;
            this.dgv_flippable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_flippable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_flippable.Location = new System.Drawing.Point(3, 32);
            this.dgv_flippable.Name = "dgv_flippable";
            this.dgv_flippable.Size = new System.Drawing.Size(593, 494);
            this.dgv_flippable.TabIndex = 2;
            this.dgv_flippable.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgv_flippable_MouseUp);
            // 
            // btn_flip
            // 
            this.btn_flip.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_flip.Location = new System.Drawing.Point(3, 3);
            this.btn_flip.Name = "btn_flip";
            this.btn_flip.Size = new System.Drawing.Size(189, 23);
            this.btn_flip.TabIndex = 0;
            this.btn_flip.Text = "Flip All";
            this.btn_flip.UseVisualStyleBackColor = true;
            this.btn_flip.Click += new System.EventHandler(this.btn_flip_Click);
            // 
            // btn_normal
            // 
            this.btn_normal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_normal.Location = new System.Drawing.Point(198, 3);
            this.btn_normal.Name = "btn_normal";
            this.btn_normal.Size = new System.Drawing.Size(190, 23);
            this.btn_normal.TabIndex = 1;
            this.btn_normal.Text = "All Normal";
            this.btn_normal.UseVisualStyleBackColor = true;
            this.btn_normal.Click += new System.EventHandler(this.btn_normal_Click);
            // 
            // tmr_popup
            // 
            this.tmr_popup.Interval = 3000;
            this.tmr_popup.Tick += new System.EventHandler(this.tmr_popup_Tick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Device Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // verticalDataGridViewTextBoxColumn
            // 
            this.verticalDataGridViewTextBoxColumn.DataPropertyName = "vertical";
            this.verticalDataGridViewTextBoxColumn.HeaderText = "Vertical Scroll";
            this.verticalDataGridViewTextBoxColumn.Name = "verticalDataGridViewTextBoxColumn";
            this.verticalDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.verticalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.verticalDataGridViewTextBoxColumn.ThreeState = true;
            // 
            // horizontalDataGridViewTextBoxColumn
            // 
            this.horizontalDataGridViewTextBoxColumn.DataPropertyName = "horizontal";
            this.horizontalDataGridViewTextBoxColumn.HeaderText = "Horizontal Scroll";
            this.horizontalDataGridViewTextBoxColumn.Name = "horizontalDataGridViewTextBoxColumn";
            this.horizontalDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.horizontalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.horizontalDataGridViewTextBoxColumn.ThreeState = true;
            // 
            // flippableBindingSource
            // 
            this.flippableBindingSource.DataSource = typeof(WindowsFormsApplication1.Flippable);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 529);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Flip Mouse Wheel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_flippable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flippableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_flippable;
        private System.Windows.Forms.Button btn_flip;
        private System.Windows.Forms.Button btn_normal;
        private System.Windows.Forms.BindingSource flippableBindingSource;
        private System.Windows.Forms.Button btn_showAll;
        private System.Windows.Forms.Timer tmr_popup;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn verticalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn horizontalDataGridViewTextBoxColumn;
    }
}


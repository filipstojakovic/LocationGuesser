﻿
namespace FindMyLocations
{
	partial class MapForm
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
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.map = new GMap.NET.WindowsForms.GMapControl();
			this.webBrowser = new System.Windows.Forms.WebBrowser();
			this.chooseBtn = new System.Windows.Forms.Button();
			this.newLocation = new System.Windows.Forms.Button();
			this.distanceLbl = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(0, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(842, 742);
			this.splitter1.TabIndex = 0;
			this.splitter1.TabStop = false;
			// 
			// map
			// 
			this.map.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.map.Bearing = 0F;
			this.map.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.map.CanDragMap = true;
			this.map.Dock = System.Windows.Forms.DockStyle.Fill;
			this.map.EmptyTileColor = System.Drawing.Color.Navy;
			this.map.GrayScaleMode = false;
			this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
			this.map.LevelsKeepInMemory = 5;
			this.map.Location = new System.Drawing.Point(876, 3);
			this.map.MarkersEnabled = true;
			this.map.MaxZoom = 2;
			this.map.MinZoom = 2;
			this.map.MouseWheelZoomEnabled = true;
			this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
			this.map.Name = "map";
			this.map.NegativeMode = false;
			this.map.PolygonsEnabled = true;
			this.map.RetryLoadTile = 0;
			this.map.RoutesEnabled = true;
			this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
			this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
			this.map.ShowTileGridLines = false;
			this.map.Size = new System.Drawing.Size(431, 365);
			this.map.TabIndex = 1;
			this.map.Zoom = 0D;
			// 
			// webBrowser
			// 
			this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser.Location = new System.Drawing.Point(3, 3);
			this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser.Name = "webBrowser";
			this.tableLayoutPanel1.SetRowSpan(this.webBrowser, 2);
			this.webBrowser.ScrollBarsEnabled = false;
			this.webBrowser.Size = new System.Drawing.Size(867, 736);
			this.webBrowser.TabIndex = 2;
			// 
			// chooseBtn
			// 
			this.chooseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.chooseBtn.Location = new System.Drawing.Point(3, 3);
			this.chooseBtn.Name = "chooseBtn";
			this.chooseBtn.Size = new System.Drawing.Size(172, 104);
			this.chooseBtn.TabIndex = 3;
			this.chooseBtn.Text = "Choose";
			this.chooseBtn.UseVisualStyleBackColor = true;
			this.chooseBtn.Click += new System.EventHandler(this.chooseBtn_Click);
			// 
			// newLocation
			// 
			this.newLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.newLocation.Location = new System.Drawing.Point(3, 113);
			this.newLocation.Name = "newLocation";
			this.newLocation.Size = new System.Drawing.Size(172, 104);
			this.newLocation.TabIndex = 4;
			this.newLocation.Text = "New location";
			this.newLocation.UseVisualStyleBackColor = true;
			this.newLocation.Click += new System.EventHandler(this.newLocation_Click);
			// 
			// distanceLbl
			// 
			this.distanceLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.distanceLbl.AutoSize = true;
			this.distanceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.distanceLbl.Location = new System.Drawing.Point(181, 78);
			this.distanceLbl.Name = "distanceLbl";
			this.distanceLbl.Size = new System.Drawing.Size(93, 32);
			this.distanceLbl.TabIndex = 5;
			this.distanceLbl.Text = "label1";
			this.distanceLbl.Visible = false;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.Controls.Add(this.webBrowser, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.map, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1310, 742);
			this.tableLayoutPanel1.TabIndex = 6;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.chooseBtn);
			this.flowLayoutPanel1.Controls.Add(this.distanceLbl);
			this.flowLayoutPanel1.Controls.Add(this.newLocation);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(876, 374);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(431, 365);
			this.flowLayoutPanel1.TabIndex = 3;
			// 
			// MapForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1311, 742);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.splitter1);
			this.Name = "MapForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Location Guesser";
			this.SizeChanged += new System.EventHandler(this.MapForm_SizeChanged);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Splitter splitter1;
		private GMap.NET.WindowsForms.GMapControl map;
		private System.Windows.Forms.WebBrowser webBrowser;
		private System.Windows.Forms.Button chooseBtn;
		private System.Windows.Forms.Button newLocation;
		private System.Windows.Forms.Label distanceLbl;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}


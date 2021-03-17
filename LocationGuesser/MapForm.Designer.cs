
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
			this.map = new GMap.NET.WindowsForms.GMapControl();
			this.webBrowser = new System.Windows.Forms.WebBrowser();
			this.chooseBtn = new System.Windows.Forms.Button();
			this.newLocation = new System.Windows.Forms.Button();
			this.distanceLbl = new System.Windows.Forms.Label();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.timerLbl = new System.Windows.Forms.Label();
			this.backBtn = new System.Windows.Forms.Button();
			this.tableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
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
			this.map.Location = new System.Drawing.Point(1369, 119);
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
			this.map.Size = new System.Drawing.Size(676, 573);
			this.map.TabIndex = 1;
			this.map.Zoom = 0D;
			// 
			// webBrowser
			// 
			this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser.Location = new System.Drawing.Point(3, 3);
			this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser.Name = "webBrowser";
			this.tableLayoutPanel.SetRowSpan(this.webBrowser, 6);
			this.webBrowser.ScrollBarsEnabled = false;
			this.webBrowser.Size = new System.Drawing.Size(1358, 1153);
			this.webBrowser.TabIndex = 2;
			// 
			// chooseBtn
			// 
			this.chooseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.chooseBtn.Location = new System.Drawing.Point(1369, 814);
			this.chooseBtn.Name = "chooseBtn";
			this.chooseBtn.Size = new System.Drawing.Size(676, 108);
			this.chooseBtn.TabIndex = 3;
			this.chooseBtn.Text = "Choose";
			this.chooseBtn.UseVisualStyleBackColor = true;
			this.chooseBtn.Click += new System.EventHandler(this.chooseBtn_Click);
			// 
			// newLocation
			// 
			this.newLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.newLocation.Location = new System.Drawing.Point(1369, 929);
			this.newLocation.Name = "newLocation";
			this.newLocation.Size = new System.Drawing.Size(676, 108);
			this.newLocation.TabIndex = 4;
			this.newLocation.Text = "New location";
			this.newLocation.UseVisualStyleBackColor = true;
			this.newLocation.Click += new System.EventHandler(this.newLocation_Click);
			// 
			// distanceLbl
			// 
			this.distanceLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.distanceLbl.AutoSize = true;
			this.distanceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.distanceLbl.Location = new System.Drawing.Point(1630, 733);
			this.distanceLbl.Name = "distanceLbl";
			this.distanceLbl.Size = new System.Drawing.Size(122, 32);
			this.distanceLbl.TabIndex = 5;
			this.distanceLbl.Text = "distance";
			this.distanceLbl.Visible = false;
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.AutoSize = true;
			this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel.Controls.Add(this.webBrowser, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.timerLbl, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.map, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.distanceLbl, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.chooseBtn, 1, 3);
			this.tableLayoutPanel.Controls.Add(this.newLocation, 1, 4);
			this.tableLayoutPanel.Controls.Add(this.backBtn, 1, 5);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 4;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(1639, 928);
			this.tableLayoutPanel.TabIndex = 6;
			// 
			// timerLbl
			// 
			this.timerLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.timerLbl.AutoSize = true;
			this.timerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timerLbl.Location = new System.Drawing.Point(1628, 38);
			this.timerLbl.Name = "timerLbl";
			this.timerLbl.Size = new System.Drawing.Size(127, 32);
			this.timerLbl.TabIndex = 3;
			this.timerLbl.Text = "00:00:00";
			// 
			// backBtn
			// 
			this.backBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.backBtn.Location = new System.Drawing.Point(1369, 1044);
			this.backBtn.Name = "backBtn";
			this.backBtn.Size = new System.Drawing.Size(676, 113);
			this.backBtn.TabIndex = 6;
			this.backBtn.Text = "Back to start";
			this.backBtn.UseVisualStyleBackColor = true;
			// 
			// MapForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1311, 742);
			this.Controls.Add(this.tableLayoutPanel);
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "MapForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Location Guesser";
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private GMap.NET.WindowsForms.GMapControl map;
		private System.Windows.Forms.WebBrowser webBrowser;
		private System.Windows.Forms.Button chooseBtn;
		private System.Windows.Forms.Button newLocation;
		private System.Windows.Forms.Label distanceLbl;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Label timerLbl;
		private System.Windows.Forms.Button backBtn;
	}
}


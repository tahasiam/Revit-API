/*
 * Created by SharpDevelop.
 * User: t.siamwala
 * Date: 7/31/2017
 * Time: 11:10 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Point_Layout
{
	partial class Move
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_Z1;
		private System.Windows.Forms.Label lbl_Y1;
		private System.Windows.Forms.Label lbl_X1;
		private System.Windows.Forms.TextBox txt_Z1;
		private System.Windows.Forms.TextBox txt_Y1;
		private System.Windows.Forms.TextBox txt_X1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lbl_Z2;
		private System.Windows.Forms.Label lbl_Y2;
		private System.Windows.Forms.Label lbl_X2;
		private System.Windows.Forms.TextBox txt_Z2;
		private System.Windows.Forms.TextBox txt_Y2;
		private System.Windows.Forms.TextBox txt_X2;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStrip_Status;
		private System.Windows.Forms.Button btn_Move;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Button btn_Ok;
		private System.Windows.Forms.RadioButton rdbtn_meter;
		private System.Windows.Forms.RadioButton rdbtn_feet;
		private System.Windows.Forms.GroupBox groupBox3;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbl_Z1 = new System.Windows.Forms.Label();
			this.lbl_Y1 = new System.Windows.Forms.Label();
			this.lbl_X1 = new System.Windows.Forms.Label();
			this.txt_Z1 = new System.Windows.Forms.TextBox();
			this.txt_Y1 = new System.Windows.Forms.TextBox();
			this.txt_X1 = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lbl_Z2 = new System.Windows.Forms.Label();
			this.lbl_Y2 = new System.Windows.Forms.Label();
			this.lbl_X2 = new System.Windows.Forms.Label();
			this.txt_Z2 = new System.Windows.Forms.TextBox();
			this.txt_Y2 = new System.Windows.Forms.TextBox();
			this.txt_X2 = new System.Windows.Forms.TextBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStrip_Status = new System.Windows.Forms.ToolStripStatusLabel();
			this.btn_Move = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_Ok = new System.Windows.Forms.Button();
			this.rdbtn_meter = new System.Windows.Forms.RadioButton();
			this.rdbtn_feet = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lbl_Z1);
			this.groupBox1.Controls.Add(this.lbl_Y1);
			this.groupBox1.Controls.Add(this.lbl_X1);
			this.groupBox1.Controls.Add(this.txt_Z1);
			this.groupBox1.Controls.Add(this.txt_Y1);
			this.groupBox1.Controls.Add(this.txt_X1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(190, 131);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Existing Co-Ordinate";
			// 
			// lbl_Z1
			// 
			this.lbl_Z1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Z1.Location = new System.Drawing.Point(12, 94);
			this.lbl_Z1.Name = "lbl_Z1";
			this.lbl_Z1.Size = new System.Drawing.Size(24, 23);
			this.lbl_Z1.TabIndex = 5;
			this.lbl_Z1.Text = "Z:";
			// 
			// lbl_Y1
			// 
			this.lbl_Y1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Y1.Location = new System.Drawing.Point(12, 61);
			this.lbl_Y1.Name = "lbl_Y1";
			this.lbl_Y1.Size = new System.Drawing.Size(24, 23);
			this.lbl_Y1.TabIndex = 4;
			this.lbl_Y1.Text = "Y:";
			// 
			// lbl_X1
			// 
			this.lbl_X1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_X1.Location = new System.Drawing.Point(12, 26);
			this.lbl_X1.Name = "lbl_X1";
			this.lbl_X1.Size = new System.Drawing.Size(24, 23);
			this.lbl_X1.TabIndex = 3;
			this.lbl_X1.Text = "X:";
			// 
			// txt_Z1
			// 
			this.txt_Z1.Location = new System.Drawing.Point(42, 94);
			this.txt_Z1.Name = "txt_Z1";
			this.txt_Z1.ReadOnly = true;
			this.txt_Z1.Size = new System.Drawing.Size(135, 20);
			this.txt_Z1.TabIndex = 2;
			// 
			// txt_Y1
			// 
			this.txt_Y1.Location = new System.Drawing.Point(42, 58);
			this.txt_Y1.Name = "txt_Y1";
			this.txt_Y1.ReadOnly = true;
			this.txt_Y1.Size = new System.Drawing.Size(135, 20);
			this.txt_Y1.TabIndex = 1;
			// 
			// txt_X1
			// 
			this.txt_X1.Location = new System.Drawing.Point(42, 23);
			this.txt_X1.Name = "txt_X1";
			this.txt_X1.ReadOnly = true;
			this.txt_X1.Size = new System.Drawing.Size(135, 20);
			this.txt_X1.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lbl_Z2);
			this.groupBox2.Controls.Add(this.lbl_Y2);
			this.groupBox2.Controls.Add(this.lbl_X2);
			this.groupBox2.Controls.Add(this.txt_Z2);
			this.groupBox2.Controls.Add(this.txt_Y2);
			this.groupBox2.Controls.Add(this.txt_X2);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(212, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(190, 131);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "New Co-Ordinate";
			// 
			// lbl_Z2
			// 
			this.lbl_Z2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Z2.Location = new System.Drawing.Point(12, 94);
			this.lbl_Z2.Name = "lbl_Z2";
			this.lbl_Z2.Size = new System.Drawing.Size(24, 23);
			this.lbl_Z2.TabIndex = 5;
			this.lbl_Z2.Text = "Z:";
			// 
			// lbl_Y2
			// 
			this.lbl_Y2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Y2.Location = new System.Drawing.Point(12, 61);
			this.lbl_Y2.Name = "lbl_Y2";
			this.lbl_Y2.Size = new System.Drawing.Size(24, 23);
			this.lbl_Y2.TabIndex = 4;
			this.lbl_Y2.Text = "Y:";
			// 
			// lbl_X2
			// 
			this.lbl_X2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_X2.Location = new System.Drawing.Point(12, 26);
			this.lbl_X2.Name = "lbl_X2";
			this.lbl_X2.Size = new System.Drawing.Size(24, 23);
			this.lbl_X2.TabIndex = 3;
			this.lbl_X2.Text = "X:";
			// 
			// txt_Z2
			// 
			this.txt_Z2.Location = new System.Drawing.Point(42, 94);
			this.txt_Z2.Name = "txt_Z2";
			this.txt_Z2.Size = new System.Drawing.Size(135, 20);
			this.txt_Z2.TabIndex = 2;
			// 
			// txt_Y2
			// 
			this.txt_Y2.Location = new System.Drawing.Point(42, 58);
			this.txt_Y2.Name = "txt_Y2";
			this.txt_Y2.Size = new System.Drawing.Size(135, 20);
			this.txt_Y2.TabIndex = 1;
			// 
			// txt_X2
			// 
			this.txt_X2.Location = new System.Drawing.Point(42, 23);
			this.txt_X2.Name = "txt_X2";
			this.txt_X2.Size = new System.Drawing.Size(135, 20);
			this.txt_X2.TabIndex = 0;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStrip_Status});
			this.statusStrip1.Location = new System.Drawing.Point(0, 222);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(411, 22);
			this.statusStrip1.TabIndex = 7;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStrip_Status
			// 
			this.toolStrip_Status.Name = "toolStrip_Status";
			this.toolStrip_Status.Size = new System.Drawing.Size(0, 17);
			// 
			// btn_Move
			// 
			this.btn_Move.Location = new System.Drawing.Point(162, 184);
			this.btn_Move.Name = "btn_Move";
			this.btn_Move.Size = new System.Drawing.Size(75, 23);
			this.btn_Move.TabIndex = 8;
			this.btn_Move.Text = "&Move";
			this.btn_Move.UseVisualStyleBackColor = true;
			this.btn_Move.Click += new System.EventHandler(this.Btn_MoveClick);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Location = new System.Drawing.Point(324, 184);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_Cancel.TabIndex = 9;
			this.btn_Cancel.Text = "&Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.Btn_CancelClick);
			// 
			// btn_Ok
			// 
			this.btn_Ok.Location = new System.Drawing.Point(243, 184);
			this.btn_Ok.Name = "btn_Ok";
			this.btn_Ok.Size = new System.Drawing.Size(75, 23);
			this.btn_Ok.TabIndex = 10;
			this.btn_Ok.Text = "&OK";
			this.btn_Ok.UseVisualStyleBackColor = true;
			this.btn_Ok.Click += new System.EventHandler(this.Btn_OkClick);
			// 
			// rdbtn_meter
			// 
			this.rdbtn_meter.Checked = true;
			this.rdbtn_meter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbtn_meter.Location = new System.Drawing.Point(12, 14);
			this.rdbtn_meter.Name = "rdbtn_meter";
			this.rdbtn_meter.Size = new System.Drawing.Size(84, 24);
			this.rdbtn_meter.TabIndex = 11;
			this.rdbtn_meter.TabStop = true;
			this.rdbtn_meter.Text = "in meters";
			this.rdbtn_meter.UseVisualStyleBackColor = true;
			this.rdbtn_meter.CheckedChanged += new System.EventHandler(this.Rdbtn_meterCheckedChanged);
			// 
			// rdbtn_feet
			// 
			this.rdbtn_feet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbtn_feet.Location = new System.Drawing.Point(12, 34);
			this.rdbtn_feet.Name = "rdbtn_feet";
			this.rdbtn_feet.Size = new System.Drawing.Size(68, 24);
			this.rdbtn_feet.TabIndex = 12;
			this.rdbtn_feet.Text = "in feet";
			this.rdbtn_feet.UseVisualStyleBackColor = true;
			this.rdbtn_feet.CheckedChanged += new System.EventHandler(this.Rdbtn_feetCheckedChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.rdbtn_meter);
			this.groupBox3.Controls.Add(this.rdbtn_feet);
			this.groupBox3.Location = new System.Drawing.Point(12, 149);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(101, 61);
			this.groupBox3.TabIndex = 13;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Units";
			// 
			// Move
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(411, 244);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.btn_Ok);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Move);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Move";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Move Point";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

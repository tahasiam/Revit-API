/*
 * Created by SharpDevelop.
 * User: t.siamwala
 * Date: 7/4/2017
 * Time: 2:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Point_Layout
{
	partial class Create
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_Z;
		private System.Windows.Forms.Label lbl_Y;
		private System.Windows.Forms.Label lbl_X;
		private System.Windows.Forms.Button btn_Create;
		private System.Windows.Forms.TextBox txt_Z1;
		private System.Windows.Forms.TextBox txt_Y1;
		private System.Windows.Forms.TextBox txt_X1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStrip_Status;
		private System.Windows.Forms.Button btn_LoadFamily;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btn_Ok;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.RadioButton rdbtn_meter;
		private System.Windows.Forms.RadioButton rdbtn_feet;
		
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
			this.lbl_Z = new System.Windows.Forms.Label();
			this.lbl_Y = new System.Windows.Forms.Label();
			this.lbl_X = new System.Windows.Forms.Label();
			this.txt_Z1 = new System.Windows.Forms.TextBox();
			this.txt_Y1 = new System.Windows.Forms.TextBox();
			this.txt_X1 = new System.Windows.Forms.TextBox();
			this.btn_LoadFamily = new System.Windows.Forms.Button();
			this.btn_Create = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStrip_Status = new System.Windows.Forms.ToolStripStatusLabel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rdbtn_meter = new System.Windows.Forms.RadioButton();
			this.rdbtn_feet = new System.Windows.Forms.RadioButton();
			this.btn_Ok = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lbl_Z);
			this.groupBox1.Controls.Add(this.lbl_Y);
			this.groupBox1.Controls.Add(this.lbl_X);
			this.groupBox1.Controls.Add(this.txt_Z1);
			this.groupBox1.Controls.Add(this.txt_Y1);
			this.groupBox1.Controls.Add(this.txt_X1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(190, 139);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "New Point";
			// 
			// lbl_Z
			// 
			this.lbl_Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Z.Location = new System.Drawing.Point(10, 99);
			this.lbl_Z.Name = "lbl_Z";
			this.lbl_Z.Size = new System.Drawing.Size(19, 23);
			this.lbl_Z.TabIndex = 8;
			this.lbl_Z.Text = "Z:";
			// 
			// lbl_Y
			// 
			this.lbl_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Y.Location = new System.Drawing.Point(10, 64);
			this.lbl_Y.Name = "lbl_Y";
			this.lbl_Y.Size = new System.Drawing.Size(19, 23);
			this.lbl_Y.TabIndex = 7;
			this.lbl_Y.Text = "Y:";
			// 
			// lbl_X
			// 
			this.lbl_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_X.Location = new System.Drawing.Point(10, 29);
			this.lbl_X.Name = "lbl_X";
			this.lbl_X.Size = new System.Drawing.Size(19, 23);
			this.lbl_X.TabIndex = 6;
			this.lbl_X.Text = "X:";
			// 
			// txt_Z1
			// 
			this.txt_Z1.Location = new System.Drawing.Point(35, 97);
			this.txt_Z1.Name = "txt_Z1";
			this.txt_Z1.Size = new System.Drawing.Size(135, 20);
			this.txt_Z1.TabIndex = 4;
			// 
			// txt_Y1
			// 
			this.txt_Y1.Location = new System.Drawing.Point(35, 62);
			this.txt_Y1.Name = "txt_Y1";
			this.txt_Y1.Size = new System.Drawing.Size(135, 20);
			this.txt_Y1.TabIndex = 3;
			// 
			// txt_X1
			// 
			this.txt_X1.Location = new System.Drawing.Point(35, 26);
			this.txt_X1.Name = "txt_X1";
			this.txt_X1.Size = new System.Drawing.Size(135, 20);
			this.txt_X1.TabIndex = 2;
			// 
			// btn_LoadFamily
			// 
			this.btn_LoadFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_LoadFamily.Location = new System.Drawing.Point(13, 24);
			this.btn_LoadFamily.Name = "btn_LoadFamily";
			this.btn_LoadFamily.Size = new System.Drawing.Size(75, 23);
			this.btn_LoadFamily.TabIndex = 9;
			this.btn_LoadFamily.Text = "&Load";
			this.btn_LoadFamily.UseVisualStyleBackColor = true;
			this.btn_LoadFamily.Click += new System.EventHandler(this.Btn_LoadFamilyClick);
			// 
			// btn_Create
			// 
			this.btn_Create.Location = new System.Drawing.Point(73, 163);
			this.btn_Create.Name = "btn_Create";
			this.btn_Create.Size = new System.Drawing.Size(75, 23);
			this.btn_Create.TabIndex = 5;
			this.btn_Create.Text = "&Create";
			this.btn_Create.UseVisualStyleBackColor = true;
			this.btn_Create.Click += new System.EventHandler(this.Btn_CreateClick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStrip_Status});
			this.statusStrip1.Location = new System.Drawing.Point(0, 203);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(316, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStrip_Status
			// 
			this.toolStrip_Status.Name = "toolStrip_Status";
			this.toolStrip_Status.Size = new System.Drawing.Size(0, 17);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btn_LoadFamily);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(208, 14);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(102, 61);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Load Family";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.rdbtn_meter);
			this.groupBox3.Controls.Add(this.rdbtn_feet);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(208, 80);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(102, 71);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Units";
			// 
			// rdbtn_meter
			// 
			this.rdbtn_meter.Checked = true;
			this.rdbtn_meter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbtn_meter.Location = new System.Drawing.Point(13, 17);
			this.rdbtn_meter.Name = "rdbtn_meter";
			this.rdbtn_meter.Size = new System.Drawing.Size(83, 24);
			this.rdbtn_meter.TabIndex = 9;
			this.rdbtn_meter.TabStop = true;
			this.rdbtn_meter.Text = "in meters";
			this.rdbtn_meter.UseVisualStyleBackColor = true;
			// 
			// rdbtn_feet
			// 
			this.rdbtn_feet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbtn_feet.Location = new System.Drawing.Point(13, 39);
			this.rdbtn_feet.Name = "rdbtn_feet";
			this.rdbtn_feet.Size = new System.Drawing.Size(77, 24);
			this.rdbtn_feet.TabIndex = 10;
			this.rdbtn_feet.Text = "in feet";
			this.rdbtn_feet.UseVisualStyleBackColor = true;
			// 
			// btn_Ok
			// 
			this.btn_Ok.Location = new System.Drawing.Point(154, 163);
			this.btn_Ok.Name = "btn_Ok";
			this.btn_Ok.Size = new System.Drawing.Size(75, 23);
			this.btn_Ok.TabIndex = 7;
			this.btn_Ok.Text = "&OK";
			this.btn_Ok.UseVisualStyleBackColor = true;
			this.btn_Ok.Click += new System.EventHandler(this.Btn_OkClick);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Location = new System.Drawing.Point(235, 163);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_Cancel.TabIndex = 8;
			this.btn_Cancel.Text = "&Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.Btn_CancelClick);
			// 
			// Create
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(316, 225);
			this.Controls.Add(this.btn_Create);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Ok);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.statusStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Create";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Create Point";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

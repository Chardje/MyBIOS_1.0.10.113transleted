using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

public class f : Form
{
	private IContainer m_a;

	private Label m_b;

	private Label c;

	private Label d;

	private LinkLabel e;

	private Button m_f;

	private Label g;

	private LinkLabel h;

	private Label i;

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.m_a != null)
		{
			this.m_a.Dispose();
		}
		base.Dispose(disposing);
	}

	private void a()
	{
		this.m_b = new Label();
		c = new Label();
		d = new Label();
		e = new LinkLabel();
		m_f = new Button();
		g = new Label();
		h = new LinkLabel();
		i = new Label();
		SuspendLayout();
		this.m_b.AutoSize = true;
		this.m_b.Font = new Font("Verdana", 12f, FontStyle.Regular, GraphicsUnit.Point, 204);
		this.m_b.ForeColor = Color.White;
		this.m_b.Location = new Point(35, 61);
		this.m_b.Name = "Ver";
		this.m_b.Size = new Size(162, 18);
		this.m_b.TabIndex = 1;
		this.m_b.Text = "Версія 4.3.0.8";
		c.AutoSize = true;
		c.Font = new Font("Verdana", 12f, FontStyle.Regular, GraphicsUnit.Point, 204);
		c.ForeColor = Color.White;
		c.Location = new Point(35, 115);
		c.Name = "Copyright";
		c.Size = new Size(422, 18);
		c.TabIndex = 2;
		c.Text = "Авторскі права © 2023–2024 Петра Порошенка";
		d.AutoSize = true;
		d.Font = new Font("Verdana", 12f, FontStyle.Regular, GraphicsUnit.Point, 204);
		d.ForeColor = Color.White;
		d.Location = new Point(35, 167);
		d.Name = "Site_for_link";
		d.Size = new Size(176, 18);
		d.TabIndex = 3;
		d.Text = "Домашня сторінка";
		e.AutoSize = true;
		e.Font = new Font("Verdana", 12f, FontStyle.Regular, GraphicsUnit.Point, 204);
		e.Location = new Point(240, 167);
		e.Name = "Link_biossim";
		e.Size = new Size(152, 18);
		e.TabIndex = 1;
		e.TabStop = true;
		e.Text = "president.gov.ua";
		e.LinkClicked += b;
		m_f.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		m_f.Location = new Point(258, 247);
		m_f.Name = "OK";
		m_f.Size = new Size(110, 32);
		m_f.TabIndex = 0;
		m_f.Text = "ОК";
		m_f.UseVisualStyleBackColor = true;
		m_f.Click += a;
		g.AutoSize = true;
		g.Font = new Font("Verdana", 12f, FontStyle.Regular, GraphicsUnit.Point, 204);
		g.ForeColor = Color.White;
		g.Location = new Point(35, 197);
		g.Name = "Email_for_link";
		g.Size = new Size(168, 18);
		g.TabIndex = 6;
		g.Text = "Куди скаржитися - ";
		h.AutoSize = true;
		h.Font = new Font("Verdana", 12f, FontStyle.Regular, GraphicsUnit.Point, 204);
		h.Location = new Point(240, 197);
		h.Name = "Link_email";
		h.Size = new Size(162, 18);
		h.TabIndex = 2;
		h.TabStop = true;
		h.Text = "Богові скаржіться";
		h.LinkClicked += a;
		i.AutoSize = true;
		i.Font = new Font("Verdana", 12f, FontStyle.Regular, GraphicsUnit.Point, 204);
		i.ForeColor = Color.White;
		i.Location = new Point(35, 34);
		i.Name = "AdditionalName";
		i.Size = new Size(584, 18);
		i.TabIndex = 21;
		i.Text = "MyBIOS — емулятор BIOS Setup Utility материнської плати ASUS P5K";
		base.AutoScaleDimensions = new SizeF(9f, 18f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.DimGray;
		base.ClientSize = new Size(644, 291);
		base.Controls.Add(i);
		base.Controls.Add(h);
		base.Controls.Add(g);
		base.Controls.Add(m_f);
		base.Controls.Add(e);
		base.Controls.Add(d);
		base.Controls.Add(this.m_b);
		base.Controls.Add(c);
		Font = new Font("Verdana", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "About_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Про програму";
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public f()
	{
		a();
	}

	private void a(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void b(object A_0, LinkLabelLinkClickedEventArgs A_1)
	{
		Process.Start("https://www.president.gov.ua/");
	}

	private void a(object A_0, LinkLabelLinkClickedEventArgs A_1)
	{
		Process.Start("https://www.cerkva.info/");
	}
}

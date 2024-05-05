using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MyBIOS.Properties;

public class z : Form
{
	private const int m_a = 1;

	private IContainer m_b;

	private PictureBox m_c;

	private PictureBox d;

	private Panel e;

	private Panel f;

	private PictureBox g;

	private Panel h;

	private Panel i;

	private Panel j;

	private Panel k;

	private Panel l;

	private Label m;

	private Label n;

	private Label o;

	private Label p;

	private Label q;

	private u r;

	private int s;

	public bool t = true;

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.m_b != null)
		{
			this.m_b.Dispose();
		}
		base.Dispose(disposing);
	}

	private void c()
	{
		this.m_c = new PictureBox();
		d = new PictureBox();
		e = new Panel();
		m = new Label();
		n = new Label();
		f = new Panel();
		o = new Label();
		p = new Label();
		g = new PictureBox();
		h = new Panel();
		i = new Panel();
		j = new Panel();
		k = new Panel();
		l = new Panel();
		q = new Label();
		((ISupportInitialize)this.m_c).BeginInit();
		((ISupportInitialize)d).BeginInit();
		e.SuspendLayout();
		f.SuspendLayout();
		((ISupportInitialize)g).BeginInit();
		SuspendLayout();
		this.m_c.Dock = DockStyle.Top;
		this.m_c.Image = Resources.ShapkaAll;
		this.m_c.Location = new Point(0, 0);
		this.m_c.Name = "Shapka";
		this.m_c.Size = new Size(1280, 35);
		this.m_c.SizeMode = PictureBoxSizeMode.StretchImage;
		this.m_c.TabIndex = 0;
		this.m_c.TabStop = false;
		d.Dock = DockStyle.Top;
		d.Image = Resources.Tools;
		d.Location = new Point(0, 35);
		d.Name = "VerhMenu";
		d.Size = new Size(1280, 35);
		d.SizeMode = PictureBoxSizeMode.StretchImage;
		d.TabIndex = 1;
		d.TabStop = false;
		e.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		e.AutoScroll = true;
		e.BackColor = Color.FromArgb(190, 190, 190);
		e.Controls.Add(m);
		e.Controls.Add(n);
		e.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		e.ForeColor = Color.FromArgb(27, 35, 165);
		e.Location = new Point(12, 92);
		e.Name = "Lev_Panel";
		e.Size = new Size(868, 877);
		e.TabIndex = 2;
		m.AutoSize = true;
		m.Location = new Point(22, 103);
		m.Name = "ASUSOCProfile";
		m.Size = new Size(294, 34);
		m.TabIndex = 1;
		m.Text = "► ASUS O.C. Profile";
		n.AutoSize = true;
		n.Location = new Point(22, 50);
		n.Name = "ASUSEZFlash2";
		n.Size = new Size(246, 34);
		n.TabIndex = 0;
		n.Text = "ASUS EZ Flash 2";
		f.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		f.AutoScroll = true;
		f.Controls.Add(o);
		f.Controls.Add(p);
		f.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		f.ForeColor = Color.FromArgb(27, 35, 165);
		f.Location = new Point(884, 92);
		f.Name = "Prav_Panel";
		f.Size = new Size(382, 877);
		f.TabIndex = 3;
		o.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		o.Location = new Point(6, 590);
		o.Name = "Help_Niz";
		o.Size = new Size(372, 250);
		o.TabIndex = 1;
		p.Location = new Point(6, 15);
		p.Name = "Help_Verh";
		p.Size = new Size(372, 470);
		p.TabIndex = 0;
		g.Dock = DockStyle.Bottom;
		g.Image = Resources.NizAll;
		g.Location = new Point(0, 989);
		g.Name = "Niz";
		g.Size = new Size(1280, 35);
		g.SizeMode = PictureBoxSizeMode.StretchImage;
		g.TabIndex = 4;
		g.TabStop = false;
		h.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		h.BackColor = Color.FromArgb(27, 35, 165);
		h.Location = new Point(10, 90);
		h.Name = "Goriz1";
		h.Size = new Size(1260, 2);
		h.TabIndex = 0;
		i.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		i.BackColor = Color.FromArgb(27, 35, 165);
		i.Location = new Point(10, 90);
		i.Name = "Vert1";
		i.Size = new Size(4, 879);
		i.TabIndex = 0;
		j.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		j.BackColor = Color.FromArgb(27, 35, 165);
		j.Location = new Point(880, 90);
		j.Name = "Vert2";
		j.Size = new Size(4, 879);
		j.TabIndex = 1;
		k.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		k.BackColor = Color.FromArgb(27, 35, 165);
		k.Location = new Point(10, 969);
		k.Name = "Goriz2";
		k.Size = new Size(1260, 2);
		k.TabIndex = 1;
		l.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		l.BackColor = Color.FromArgb(27, 35, 165);
		l.Location = new Point(1266, 90);
		l.Name = "Vert3";
		l.Size = new Size(4, 879);
		l.TabIndex = 2;
		q.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		q.BackColor = Color.FromArgb(4, 7, 80);
		q.Cursor = Cursors.Hand;
		q.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Underline, GraphicsUnit.Point, 204);
		q.ForeColor = Color.FromArgb(224, 224, 224);
		q.Location = new Point(1125, 2);
		q.Name = "ShowQuestion";
		q.Size = new Size(155, 30);
		q.TabIndex = 6;
		q.Text = "Нагадати завдання";
		q.TextAlign = ContentAlignment.MiddleCenter;
		q.Visible = false;
		q.MouseLeave += a;
		q.Click += c;
		q.MouseEnter += b;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(190, 190, 190);
		base.ClientSize = new Size(1280, 1024);
		base.Controls.Add(q);
		base.Controls.Add(k);
		base.Controls.Add(h);
		base.Controls.Add(g);
		base.Controls.Add(d);
		base.Controls.Add(this.m_c);
		base.Controls.Add(l);
		base.Controls.Add(j);
		base.Controls.Add(i);
		base.Controls.Add(e);
		base.Controls.Add(f);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "Tools_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Tools_Form";
		base.WindowState = FormWindowState.Maximized;
		base.FormClosing += a;
		base.KeyDown += a;
		((ISupportInitialize)this.m_c).EndInit();
		((ISupportInitialize)d).EndInit();
		e.ResumeLayout(performLayout: false);
		e.PerformLayout();
		f.ResumeLayout(performLayout: false);
		((ISupportInitialize)g).EndInit();
		ResumeLayout(performLayout: false);
	}

	public z(u A_0)
	{
		r = A_0;
		c();
		if (r.h)
		{
			q.Visible = true;
		}
		o.Text = r.p;
		b();
	}

	private void b()
	{
		foreach (Label control in e.Controls)
		{
			control.ForeColor = r.g;
		}
		switch (s)
		{
		case 0:
			n.ForeColor = Color.White;
			p.Text = r.my;
			break;
		case 1:
			m.ForeColor = Color.White;
			p.Text = "";
			break;
		}
	}

	private void a()
	{
		switch (s)
		{
		}
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		if (A_1.KeyCode == Keys.Up && s > 0)
		{
			s--;
			b();
		}
		else if (A_1.KeyCode == Keys.Down && s < 1)
		{
			s++;
			b();
		}
		else if (A_1.KeyCode == Keys.Left)
		{
			r.d.Show();
			Hide();
			s = 0;
			b();
		}
		else if (A_1.KeyCode == Keys.Right)
		{
			r.f.Show();
			Hide();
			s = 0;
			b();
		}
		else if (A_1.KeyCode == Keys.Return)
		{
			a();
		}
		else if (A_1.KeyCode == Keys.Prior || A_1.KeyCode == Keys.Home)
		{
			s = 0;
			b();
		}
		else if (A_1.KeyCode == Keys.Next || A_1.KeyCode == Keys.End)
		{
			s = 1;
			b();
		}
		else if (A_1.KeyCode == Keys.F1)
		{
			r.ng();
		}
		else if (A_1.KeyCode == Keys.F5)
		{
			r.na();
		}
		else if (A_1.KeyCode == Keys.F7)
		{
			r.nd();
		}
		else if (A_1.KeyCode == Keys.F10)
		{
			r.l();
		}
		else if (A_1.KeyCode == Keys.Escape)
		{
			r.nf();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		A_1.Cancel = t;
	}

	private void c(object A_0, EventArgs A_1)
	{
		r.nc();
	}

	private void b(object A_0, EventArgs A_1)
	{
		q.ForeColor = Color.White;
	}

	private void a(object A_0, EventArgs A_1)
	{
		q.ForeColor = Color.FromArgb(224, 224, 224);
	}
}

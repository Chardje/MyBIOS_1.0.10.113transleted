using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MyBIOS.Properties;

public class k : Form
{
	private const int m_a = 3;

	private IContainer m_b;

	private PictureBox m_c;

	private PictureBox d;

	private Panel e;

	private Panel f;

	private PictureBox g;

	private Panel h;

	private Panel i;

	private Panel j;

	private Panel m_k;

	private Panel l;

	private Label m;

	private Label n;

	private Label o;

	private Label p;

	private Label q;

	private Label r;

	private Label s;

	private u t;

	private e u;

	private aj v;

	private w w;

	private r x;

	private int y;

	public bool z = true;

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
		o = new Label();
		p = new Label();
		f = new Panel();
		r = new Label();
		q = new Label();
		g = new PictureBox();
		h = new Panel();
		i = new Panel();
		j = new Panel();
		m_k = new Panel();
		l = new Panel();
		s = new Label();
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
		d.Image = Resources.Boot;
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
		e.Controls.Add(o);
		e.Controls.Add(p);
		e.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		e.ForeColor = Color.FromArgb(27, 35, 165);
		e.Location = new Point(12, 92);
		e.Name = "Lev_Panel";
		e.Size = new Size(868, 877);
		e.TabIndex = 2;
		m.AutoSize = true;
		m.Location = new Point(22, 181);
		m.Name = "Security";
		m.Size = new Size(166, 34);
		m.TabIndex = 3;
		m.Text = "► Security";
		n.AutoSize = true;
		n.Location = new Point(22, 147);
		n.Name = "BootSettingsConfiguration";
		n.Size = new Size(441, 34);
		n.TabIndex = 2;
		n.Text = "► Boot Settings Configuration";
		o.AutoSize = true;
		o.Location = new Point(22, 84);
		o.Name = "HardDiskDrives";
		o.Size = new Size(284, 34);
		o.TabIndex = 1;
		o.Text = "► Hard Disk Drives";
		p.AutoSize = true;
		p.Location = new Point(22, 50);
		p.Name = "BootDevicePriority";
		p.Size = new Size(329, 34);
		p.TabIndex = 0;
		p.Text = "► Boot Device Priority";
		f.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		f.AutoScroll = true;
		f.Controls.Add(r);
		f.Controls.Add(q);
		f.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		f.ForeColor = Color.FromArgb(27, 35, 165);
		f.Location = new Point(884, 92);
		f.Name = "Prav_Panel";
		f.Size = new Size(382, 877);
		f.TabIndex = 3;
		r.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		r.Location = new Point(6, 590);
		r.Name = "Help_Niz";
		r.Size = new Size(372, 250);
		r.TabIndex = 1;
		q.Location = new Point(6, 15);
		q.Name = "Help_Verh";
		q.Size = new Size(372, 470);
		q.TabIndex = 0;
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
		m_k.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		m_k.BackColor = Color.FromArgb(27, 35, 165);
		m_k.Location = new Point(10, 969);
		m_k.Name = "Goriz2";
		m_k.Size = new Size(1260, 2);
		m_k.TabIndex = 1;
		l.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		l.BackColor = Color.FromArgb(27, 35, 165);
		l.Location = new Point(1266, 90);
		l.Name = "Vert3";
		l.Size = new Size(4, 879);
		l.TabIndex = 2;
		s.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		s.BackColor = Color.FromArgb(4, 7, 80);
		s.Cursor = Cursors.Hand;
		s.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Underline, GraphicsUnit.Point, 204);
		s.ForeColor = Color.FromArgb(224, 224, 224);
		s.Location = new Point(1125, 2);
		s.Name = "ShowQuestion";
		s.Size = new Size(155, 30);
		s.TabIndex = 6;
		s.Text = "Напомнить задание";
		s.TextAlign = ContentAlignment.MiddleCenter;
		s.Visible = false;
		s.MouseLeave += a;
		s.Click += c;
		s.MouseEnter += b;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(190, 190, 190);
		base.ClientSize = new Size(1280, 1024);
		base.Controls.Add(s);
		base.Controls.Add(m_k);
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
		base.Name = "Boot_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Boot_Form";
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

	public k(u A_0)
	{
		t = A_0;
		c();
		if (t.h)
		{
			s.Visible = true;
		}
		r.Text = t.p;
		b();
	}

	private void b()
	{
		foreach (Label control in e.Controls)
		{
			control.ForeColor = t.g;
		}
		switch (y)
		{
		case 0:
			q.Text = t.lq;
			p.ForeColor = Color.White;
			break;
		case 1:
			q.Text = t.lx;
			o.ForeColor = Color.White;
			break;
		case 2:
			q.Text = t.l2;
			n.ForeColor = Color.White;
			break;
		case 3:
			q.Text = "";
			m.ForeColor = Color.White;
			break;
		}
	}

	private void a()
	{
		switch (y)
		{
		case 0:
			u = new e(t);
			u.ShowDialog();
			break;
		case 1:
			v = new aj(t);
			v.ShowDialog();
			break;
		case 2:
			w = new w(t);
			w.ShowDialog();
			break;
		case 3:
			x = new r(t);
			x.ShowDialog();
			break;
		}
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		if (A_1.KeyCode == Keys.Up && y > 0)
		{
			y--;
			b();
		}
		else if (A_1.KeyCode == Keys.Down && y < 3)
		{
			y++;
			b();
		}
		else if (A_1.KeyCode == Keys.Left)
		{
			t.c.Show();
			Hide();
			y = 0;
			b();
		}
		else if (A_1.KeyCode == Keys.Right)
		{
			t.e.Show();
			Hide();
			y = 0;
			b();
		}
		else if (A_1.KeyCode == Keys.Return)
		{
			a();
		}
		else if (A_1.KeyCode == Keys.Prior || A_1.KeyCode == Keys.Home)
		{
			y = 0;
			b();
		}
		else if (A_1.KeyCode == Keys.Next || A_1.KeyCode == Keys.End)
		{
			y = 3;
			b();
		}
		else if (A_1.KeyCode == Keys.F1)
		{
			t.ng();
		}
		else if (A_1.KeyCode == Keys.F5)
		{
			t.na();
		}
		else if (A_1.KeyCode == Keys.F7)
		{
			t.nd();
		}
		else if (A_1.KeyCode == Keys.F10)
		{
			t.l();
		}
		else if (A_1.KeyCode == Keys.Escape)
		{
			t.nf();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		A_1.Cancel = z;
	}

	private void c(object A_0, EventArgs A_1)
	{
		t.nc();
	}

	private void b(object A_0, EventArgs A_1)
	{
		s.ForeColor = Color.White;
	}

	private void a(object A_0, EventArgs A_1)
	{
		s.ForeColor = Color.FromArgb(224, 224, 224);
	}
}

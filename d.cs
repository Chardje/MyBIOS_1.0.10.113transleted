using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MyBIOS.Properties;

public class d : Form
{
	private const int m_a = 5;

	private IContainer m_b;

	private PictureBox m_c;

	private PictureBox m_d;

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

	private Label r;

	private Label s;

	private Label t;

	private Label u;

	private u v;

	private ai w;

	private c x;

	private y y;

	private o z;

	private t aa;

	private aa ab;

	private int ac;

	public bool ad = true;

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
		e = new Panel();
		m = new Label();
		n = new Label();
		o = new Label();
		p = new Label();
		q = new Label();
		r = new Label();
		f = new Panel();
		t = new Label();
		s = new Label();
		h = new Panel();
		i = new Panel();
		j = new Panel();
		k = new Panel();
		l = new Panel();
		u = new Label();
		g = new PictureBox();
		m_d = new PictureBox();
		this.m_c = new PictureBox();
		e.SuspendLayout();
		f.SuspendLayout();
		((ISupportInitialize)g).BeginInit();
		((ISupportInitialize)m_d).BeginInit();
		((ISupportInitialize)this.m_c).BeginInit();
		SuspendLayout();
		e.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		e.AutoScroll = true;
		e.BackColor = Color.FromArgb(190, 190, 190);
		e.Controls.Add(m);
		e.Controls.Add(n);
		e.Controls.Add(o);
		e.Controls.Add(p);
		e.Controls.Add(q);
		e.Controls.Add(r);
		e.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		e.ForeColor = Color.FromArgb(27, 35, 165);
		e.Location = new Point(12, 92);
		e.Name = "Lev_Panel";
		e.Size = new Size(868, 877);
		e.TabIndex = 2;
		m.AutoSize = true;
		m.Location = new Point(22, 255);
		m.Name = "PCIPnP";
		m.Size = new Size(156, 34);
		m.TabIndex = 5;
		m.Text = "► PCIPnP";
		n.AutoSize = true;
		n.Location = new Point(22, 221);
		n.Name = "OnboardDevicesConfiguration";
		n.Size = new Size(491, 34);
		n.TabIndex = 4;
		n.Text = "► Onboard Devices Configuration";
		o.AutoSize = true;
		o.Location = new Point(22, 187);
		o.Name = "Chipset";
		o.Size = new Size(159, 34);
		o.TabIndex = 3;
		o.Text = "► Chipset";
		p.AutoSize = true;
		p.Location = new Point(22, 153);
		p.Name = "CPUConfiguration";
		p.Size = new Size(313, 34);
		p.TabIndex = 2;
		p.Text = "► CPU Configuration";
		q.AutoSize = true;
		q.Location = new Point(22, 84);
		q.Name = "USBConfiguration";
		q.Size = new Size(312, 34);
		q.TabIndex = 1;
		q.Text = "► USB Configuration";
		r.AutoSize = true;
		r.Location = new Point(22, 50);
		r.Name = "JumperFreeConfiguration";
		r.Size = new Size(418, 34);
		r.TabIndex = 0;
		r.Text = "► JumperFree Configuration";
		f.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		f.AutoScroll = true;
		f.Controls.Add(t);
		f.Controls.Add(s);
		f.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		f.ForeColor = Color.FromArgb(27, 35, 165);
		f.Location = new Point(884, 92);
		f.Name = "Prav_Panel";
		f.Size = new Size(382, 877);
		f.TabIndex = 3;
		t.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		t.Location = new Point(6, 590);
		t.Name = "Help_Niz";
		t.Size = new Size(372, 250);
		t.TabIndex = 1;
		s.Location = new Point(6, 15);
		s.Name = "Help_Verh";
		s.Size = new Size(372, 470);
		s.TabIndex = 0;
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
		u.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		u.BackColor = Color.FromArgb(4, 7, 80);
		u.Cursor = Cursors.Hand;
		u.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Underline, GraphicsUnit.Point, 204);
		u.ForeColor = Color.FromArgb(224, 224, 224);
		u.Location = new Point(1125, 2);
		u.Name = "ShowQuestion";
		u.Size = new Size(155, 30);
		u.TabIndex = 6;
		u.Text = "Нагадати завдання";
		u.TextAlign = ContentAlignment.MiddleCenter;
		u.Visible = false;
		u.MouseLeave += a;
		u.Click += c;
		u.MouseEnter += b;
		g.Dock = DockStyle.Bottom;
		g.Image = Resources.NizAll;
		g.Location = new Point(0, 989);
		g.Name = "Niz";
		g.Size = new Size(1280, 35);
		g.SizeMode = PictureBoxSizeMode.StretchImage;
		g.TabIndex = 4;
		g.TabStop = false;
		m_d.Dock = DockStyle.Top;
		m_d.Image = Resources.Advanced;
		m_d.Location = new Point(0, 35);
		m_d.Name = "VerhMenu";
		m_d.Size = new Size(1280, 35);
		m_d.SizeMode = PictureBoxSizeMode.StretchImage;
		m_d.TabIndex = 1;
		m_d.TabStop = false;
		this.m_c.Dock = DockStyle.Top;
		this.m_c.Image = Resources.ShapkaAll;
		this.m_c.Location = new Point(0, 0);
		this.m_c.Name = "Shapka";
		this.m_c.Size = new Size(1280, 35);
		this.m_c.SizeMode = PictureBoxSizeMode.StretchImage;
		this.m_c.TabIndex = 0;
		this.m_c.TabStop = false;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(190, 190, 190);
		base.ClientSize = new Size(1280, 1024);
		base.Controls.Add(u);
		base.Controls.Add(k);
		base.Controls.Add(h);
		base.Controls.Add(g);
		base.Controls.Add(m_d);
		base.Controls.Add(this.m_c);
		base.Controls.Add(l);
		base.Controls.Add(j);
		base.Controls.Add(i);
		base.Controls.Add(e);
		base.Controls.Add(f);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "Advanced_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Advanced_Form";
		base.WindowState = FormWindowState.Maximized;
		base.FormClosing += a;
		base.KeyDown += a;
		e.ResumeLayout(performLayout: false);
		e.PerformLayout();
		f.ResumeLayout(performLayout: false);
		((ISupportInitialize)g).EndInit();
		((ISupportInitialize)m_d).EndInit();
		((ISupportInitialize)this.m_c).EndInit();
		ResumeLayout(performLayout: false);
	}

	public d(u A_0)
	{
		v = A_0;
		c();
		if (v.h)
		{
			u.Visible = true;
		}
		t.Text = v.p;
		b();
	}

	private void b()
	{
		foreach (Label control in e.Controls)
		{
			control.ForeColor = v.g;
		}
		switch (ac)
		{
		case 0:
			s.Text = "";
			r.ForeColor = Color.White;
			break;
		case 1:
			s.Text = v.g0;
			q.ForeColor = Color.White;
			break;
		case 2:
			s.Text = v.hk;
			p.ForeColor = Color.White;
			break;
		case 3:
			s.Text = v.h9;
			o.ForeColor = Color.White;
			break;
		case 4:
			s.Text = v.@in;
			n.ForeColor = Color.White;
			break;
		case 5:
			s.Text = v.jc;
			m.ForeColor = Color.White;
			break;
		}
	}

	private void a()
	{
		switch (ac)
		{
		case 0:
			w = new ai(v);
			w.ShowDialog();
			break;
		case 1:
			x = new c(v);
			x.ShowDialog();
			break;
		case 2:
			y = new y(v);
			y.ShowDialog();
			break;
		case 3:
			z = new o(v);
			z.ShowDialog();
			break;
		case 4:
			aa = new t(v);
			aa.ShowDialog();
			break;
		case 5:
			ab = new aa(v);
			ab.ShowDialog();
			break;
		}
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		if (A_1.KeyCode == Keys.Up && ac > 0)
		{
			ac--;
			b();
		}
		else if (A_1.KeyCode == Keys.Down && ac < 5)
		{
			ac++;
			b();
		}
		else if (A_1.KeyCode == Keys.Left)
		{
			v.a.Show();
			Hide();
			ac = 0;
			b();
		}
		else if (A_1.KeyCode == Keys.Right)
		{
			v.c.Show();
			Hide();
			ac = 0;
			b();
		}
		else if (A_1.KeyCode == Keys.Return)
		{
			a();
		}
		else if (A_1.KeyCode == Keys.Prior || A_1.KeyCode == Keys.Home)
		{
			ac = 0;
			b();
		}
		else if (A_1.KeyCode == Keys.Next || A_1.KeyCode == Keys.End)
		{
			ac = 5;
			b();
		}
		else if (A_1.KeyCode == Keys.F1)
		{
			v.ng();
		}
		else if (A_1.KeyCode == Keys.F5)
		{
			v.na();
		}
		else if (A_1.KeyCode == Keys.F7)
		{
			v.nd();
		}
		else if (A_1.KeyCode == Keys.F10)
		{
			v.l();
		}
		else if (A_1.KeyCode == Keys.Escape)
		{
			v.nf();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		A_1.Cancel = ad;
	}

	private void c(object A_0, EventArgs A_1)
	{
		v.nc();
	}

	private void b(object A_0, EventArgs A_1)
	{
		u.ForeColor = Color.White;
	}

	private void a(object A_0, EventArgs A_1)
	{
		u.ForeColor = Color.FromArgb(224, 224, 224);
	}
}

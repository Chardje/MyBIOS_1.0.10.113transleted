using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MyBIOS.Properties;

public class x : Form
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

	private Label v;

	private Label w;

	private Label m_x;

	private Label y;

	private Label z;

	private u aa;

	private ac ab;

	private ab ac;

	private b ad;

	private int ae;

	public bool af = true;

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
		this.m_d = new PictureBox();
		e = new Panel();
		w = new Label();
		s = new Label();
		t = new Label();
		u = new Label();
		v = new Label();
		q = new Label();
		r = new Label();
		n = new Label();
		o = new Label();
		p = new Label();
		m = new Label();
		f = new Panel();
		y = new Label();
		m_x = new Label();
		g = new PictureBox();
		h = new Panel();
		i = new Panel();
		j = new Panel();
		k = new Panel();
		l = new Panel();
		z = new Label();
		((ISupportInitialize)this.m_c).BeginInit();
		((ISupportInitialize)this.m_d).BeginInit();
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
		this.m_d.Dock = DockStyle.Top;
		this.m_d.Image = Resources.Power;
		this.m_d.Location = new Point(0, 35);
		this.m_d.Name = "VerhMenu";
		this.m_d.Size = new Size(1280, 35);
		this.m_d.SizeMode = PictureBoxSizeMode.StretchImage;
		this.m_d.TabIndex = 1;
		this.m_d.TabStop = false;
		e.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		e.AutoScroll = true;
		e.BackColor = Color.FromArgb(190, 190, 190);
		e.Controls.Add(w);
		e.Controls.Add(s);
		e.Controls.Add(t);
		e.Controls.Add(u);
		e.Controls.Add(v);
		e.Controls.Add(q);
		e.Controls.Add(r);
		e.Controls.Add(n);
		e.Controls.Add(o);
		e.Controls.Add(p);
		e.Controls.Add(m);
		e.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		e.ForeColor = Color.FromArgb(27, 35, 165);
		e.Location = new Point(12, 92);
		e.Name = "Lev_Panel";
		e.Size = new Size(868, 877);
		e.TabIndex = 2;
		w.Location = new Point(611, 274);
		w.Name = "End";
		w.Size = new Size(126, 37);
		w.TabIndex = 25;
		s.Anchor = AnchorStyles.Top;
		s.AutoSize = true;
		s.Location = new Point(504, 152);
		s.Name = "ACPIAPICSupport_VALUE";
		s.Size = new Size(97, 34);
		s.TabIndex = 9;
		s.Text = "label4";
		t.Anchor = AnchorStyles.Top;
		t.AutoSize = true;
		t.Location = new Point(504, 118);
		t.Name = "ACPIVersion_VALUE";
		t.Size = new Size(97, 34);
		t.TabIndex = 8;
		t.Text = "label3";
		u.Anchor = AnchorStyles.Top;
		u.AutoSize = true;
		u.Location = new Point(504, 84);
		u.Name = "RepostVideoonS3Resume_VALUE";
		u.Size = new Size(97, 34);
		u.TabIndex = 7;
		u.Text = "label2";
		v.Anchor = AnchorStyles.Top;
		v.AutoSize = true;
		v.Location = new Point(504, 50);
		v.Name = "SuspendMode_VALUE";
		v.Size = new Size(97, 34);
		v.TabIndex = 6;
		v.Text = "label1";
		q.AutoSize = true;
		q.Location = new Point(22, 256);
		q.Name = "HardwareMonitor";
		q.Size = new Size(300, 34);
		q.TabIndex = 5;
		q.Text = "► Hardware Monitor";
		r.AutoSize = true;
		r.Location = new Point(22, 222);
		r.Name = "APMConfiguration";
		r.Size = new Size(314, 34);
		r.TabIndex = 4;
		r.Text = "► APM Configuration";
		n.AutoSize = true;
		n.Location = new Point(22, 152);
		n.Name = "ACPIAPICSupport";
		n.Size = new Size(276, 34);
		n.TabIndex = 3;
		n.Text = "ACPI APIC Support";
		o.AutoSize = true;
		o.Location = new Point(22, 118);
		o.Name = "ACPIVersion";
		o.Size = new Size(194, 34);
		o.TabIndex = 2;
		o.Text = "ACPI Version";
		p.AutoSize = true;
		p.Location = new Point(22, 84);
		p.Name = "RepostVideoonS3Resume";
		p.Size = new Size(408, 34);
		p.TabIndex = 1;
		p.Text = "Repost Video on S3 Resume";
		m.AutoSize = true;
		m.Location = new Point(22, 50);
		m.Name = "SuspendMode";
		m.Size = new Size(223, 34);
		m.TabIndex = 0;
		m.Text = "Suspend Mode";
		f.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		f.AutoScroll = true;
		f.Controls.Add(y);
		f.Controls.Add(m_x);
		f.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		f.ForeColor = Color.FromArgb(27, 35, 165);
		f.Location = new Point(884, 92);
		f.Name = "Prav_Panel";
		f.Size = new Size(382, 877);
		f.TabIndex = 3;
		y.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		y.Location = new Point(6, 590);
		y.Name = "Help_Niz";
		y.Size = new Size(372, 250);
		y.TabIndex = 1;
		m_x.Location = new Point(6, 15);
		m_x.Name = "Help_Verh";
		m_x.Size = new Size(372, 470);
		m_x.TabIndex = 0;
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
		z.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		z.BackColor = Color.FromArgb(4, 7, 80);
		z.Cursor = Cursors.Hand;
		z.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Underline, GraphicsUnit.Point, 204);
		z.ForeColor = Color.FromArgb(224, 224, 224);
		z.Location = new Point(1125, 2);
		z.Name = "ShowQuestion";
		z.Size = new Size(155, 30);
		z.TabIndex = 6;
		z.Text = "Нагадати завдання";
		z.TextAlign = ContentAlignment.MiddleCenter;
		z.Visible = false;
		z.MouseLeave += a;
		z.Click += c;
		z.MouseEnter += b;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(190, 190, 190);
		base.ClientSize = new Size(1280, 1024);
		base.Controls.Add(z);
		base.Controls.Add(k);
		base.Controls.Add(h);
		base.Controls.Add(g);
		base.Controls.Add(this.m_d);
		base.Controls.Add(this.m_c);
		base.Controls.Add(l);
		base.Controls.Add(j);
		base.Controls.Add(i);
		base.Controls.Add(e);
		base.Controls.Add(f);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "Power_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Power_Form";
		base.WindowState = FormWindowState.Maximized;
		base.FormClosing += a;
		base.KeyDown += a;
		((ISupportInitialize)this.m_c).EndInit();
		((ISupportInitialize)this.m_d).EndInit();
		e.ResumeLayout(performLayout: false);
		e.PerformLayout();
		f.ResumeLayout(performLayout: false);
		((ISupportInitialize)g).EndInit();
		ResumeLayout(performLayout: false);
	}

	public x(u A_0)
	{
		aa = A_0;
		c();
		d();
		b();
	}

	public void d()
	{
		if (aa.h)
		{
			z.Visible = true;
		}
		int num = m.Location.X;
		int num2 = v.Location.X;
		int num3 = 0;
		if (aa.jg == "S1 (POS) only")
		{
			num3 = p.Location.Y;
			p.Visible = false;
			u.Visible = false;
		}
		else
		{
			num3 = p.Location.Y + 34;
			p.Visible = true;
			u.Visible = true;
		}
		o.Location = new Point(num, num3);
		t.Location = new Point(num2, num3);
		n.Location = new Point(num, num3 += 34);
		s.Location = new Point(num2, num3);
		r.Location = new Point(num, num3 += 68);
		q.Location = new Point(num, num3 += 34);
		v.Text = aa.k(aa.jg);
		u.Text = aa.k(aa.jj);
		t.Text = aa.k(aa.jm);
		s.Text = aa.k(aa.jp);
	}

	private void b()
	{
		foreach (Label control in e.Controls)
		{
			control.ForeColor = aa.g;
		}
		switch (ae)
		{
		case 0:
			m.ForeColor = Color.White;
			v.ForeColor = Color.White;
			m_x.Text = aa.ji;
			y.Text = aa.o;
			break;
		case 1:
			p.ForeColor = Color.White;
			u.ForeColor = Color.White;
			m_x.Text = aa.jl;
			y.Text = aa.o;
			break;
		case 2:
			o.ForeColor = Color.White;
			t.ForeColor = Color.White;
			m_x.Text = aa.jo;
			y.Text = aa.o;
			break;
		case 3:
			n.ForeColor = Color.White;
			s.ForeColor = Color.White;
			m_x.Text = aa.jr;
			y.Text = aa.o;
			break;
		case 4:
			r.ForeColor = Color.White;
			m_x.Text = aa.js;
			y.Text = aa.p;
			break;
		case 5:
			q.ForeColor = Color.White;
			m_x.Text = aa.kg;
			y.Text = aa.p;
			break;
		}
	}

	private void a()
	{
		switch (ae)
		{
		case 0:
			ab = new ac(aa, aa.jg, aa.jh);
			ab.ShowDialog();
			aa.jg = aa.m;
			break;
		case 1:
			ab = new ac(aa, aa.jj, aa.jk);
			ab.ShowDialog();
			aa.jj = aa.m;
			break;
		case 2:
			ab = new ac(aa, aa.jm, aa.jn);
			ab.ShowDialog();
			aa.jm = aa.m;
			break;
		case 3:
			ab = new ac(aa, aa.jp, aa.jq);
			ab.ShowDialog();
			aa.jp = aa.m;
			break;
		case 4:
			ac = new ab(aa);
			ac.ShowDialog();
			break;
		case 5:
			ad = new b(aa);
			ad.ShowDialog();
			break;
		}
		d();
	}

	private void a(bool A_0)
	{
		switch (ae)
		{
		case 0:
			aa.k(ref aa.jg, aa.jh, A_0);
			break;
		case 1:
			aa.k(ref aa.jj, aa.jk, A_0);
			break;
		case 2:
			aa.k(ref aa.jm, aa.jn, A_0);
			break;
		case 3:
			aa.k(ref aa.jp, aa.jq, A_0);
			break;
		}
		d();
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
        Debug.WriteLine(A_1.KeyCode);

        if (A_1.KeyCode == Keys.Up && ae > 0)
		{
			ae--;
			if (aa.jg == "S1 (POS) only" && ae == 1)
			{
				ae = 0;
			}
			b();
		}
		else if (A_1.KeyCode == Keys.Down && ae < 5)
		{
			ae++;
			if (aa.jg == "S1 (POS) only" && ae == 1)
			{
				ae = 2;
			}
			b();
		}
		else if (A_1.KeyCode == Keys.Left)
		{
			aa.b.Show();
			Hide();
			ae = 0;
			b();
		}
		else if (A_1.KeyCode == Keys.Right)
		{
			aa.d.Show();
			Hide();
			ae = 0;
			b();
		}
		else if (A_1.KeyCode == Keys.Add|| A_1.KeyCode == Keys.Oemplus)
		{
			a(A_0: true);
		}
		else if (A_1.KeyCode == Keys.Subtract|| A_1.KeyCode == Keys.OemMinus)
		{
			a(A_0: false);
		}
		else if (A_1.KeyCode == Keys.Return)
		{
			a();
		}
		else if (A_1.KeyCode == Keys.Prior || A_1.KeyCode == Keys.Home)
		{
			ae = 0;
			b();
		}
		else if (A_1.KeyCode == Keys.Next || A_1.KeyCode == Keys.End)
		{
			ae = 5;
			b();
		}
		else if (A_1.KeyCode == Keys.F1)
		{
			aa.ng();
		}
		else if (A_1.KeyCode == Keys.F5)
		{
			aa.na();
		}
		else if (A_1.KeyCode == Keys.F7)
		{
			aa.nd();
		}
		else if (A_1.KeyCode == Keys.F10)
		{
			aa.l();
		}
		else if (A_1.KeyCode == Keys.Escape)
		{
			aa.nf();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		A_1.Cancel = af;
	}

	private void c(object A_0, EventArgs A_1)
	{
		aa.nc();
	}

	private void b(object A_0, EventArgs A_1)
	{
		z.ForeColor = Color.White;
	}

	private void a(object A_0, EventArgs A_1)
	{
		z.ForeColor = Color.FromArgb(224, 224, 224);
	}
}

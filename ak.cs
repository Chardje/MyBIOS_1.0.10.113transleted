using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MyBIOS.Properties;

public class ak : Form
{
	private const int m_a = 9;

	private IContainer m_b;

	private PictureBox m_c;

	private Panel m_d;

	private Panel e;

	private Panel f;

	private Panel g;

	private Panel h;

	private Panel i;

	private Panel j;

	private Label k;

	private Label l;

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

	private Label x;

	private Label y;

	private Label z;

	private Label aa;

	private Label ab;

	private Label ac;

	private Label ad;

	private Label ae;

	private Label af;

	private Label ag;

	private Label ah;

	private Label ai;

	private Label aj;

	private Label m_ak;

	private Label al;

	private PictureBox am;

	private PictureBox an;

	private u ao;

	private ac ap;

	private g aq;

	private ae ar;

	private af @as;

	private p at;

	private ah au;

	private j av;

	private int aw;

	private int ax;

	private int ay;

	public bool az = true;

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
		am = new PictureBox();
		this.m_c = new PictureBox();
		this.m_d = new Panel();
		ai = new Label();
		ah = new Label();
		ae = new Label();
		af = new Label();
		ag = new Label();
		ac = new Label();
		ad = new Label();
		ab = new Label();
		aa = new Label();
		w = new Label();
		x = new Label();
		y = new Label();
		z = new Label();
		q = new Label();
		r = new Label();
		s = new Label();
		t = new Label();
		u = new Label();
		v = new Label();
		o = new Label();
		p = new Label();
		l = new Label();
		m = new Label();
		n = new Label();
		k = new Label();
		e = new Panel();
		m_ak = new Label();
		aj = new Label();
		an = new PictureBox();
		f = new Panel();
		g = new Panel();
		h = new Panel();
		i = new Panel();
		j = new Panel();
		al = new Label();
		((ISupportInitialize)am).BeginInit();
		((ISupportInitialize)this.m_c).BeginInit();
		this.m_d.SuspendLayout();
		e.SuspendLayout();
		((ISupportInitialize)an).BeginInit();
		SuspendLayout();
		am.Dock = DockStyle.Top;
		am.Image = Resources.ShapkaAll;
		am.Location = new Point(0, 0);
		am.Name = "Shapka";
		am.Size = new Size(1280, 35);
		am.SizeMode = PictureBoxSizeMode.StretchImage;
		am.TabIndex = 0;
		am.TabStop = false;
		this.m_c.Dock = DockStyle.Top;
		this.m_c.Image = Resources.Main;
		this.m_c.Location = new Point(0, 35);
		this.m_c.Name = "VerhMenu";
		this.m_c.Size = new Size(1280, 35);
		this.m_c.SizeMode = PictureBoxSizeMode.StretchImage;
		this.m_c.TabIndex = 1;
		this.m_c.TabStop = false;
		this.m_d.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		this.m_d.AutoScroll = true;
		this.m_d.BackColor = Color.FromArgb(190, 190, 190);
		this.m_d.Controls.Add(ai);
		this.m_d.Controls.Add(ah);
		this.m_d.Controls.Add(ae);
		this.m_d.Controls.Add(af);
		this.m_d.Controls.Add(ag);
		this.m_d.Controls.Add(ac);
		this.m_d.Controls.Add(ad);
		this.m_d.Controls.Add(ab);
		this.m_d.Controls.Add(aa);
		this.m_d.Controls.Add(w);
		this.m_d.Controls.Add(x);
		this.m_d.Controls.Add(y);
		this.m_d.Controls.Add(z);
		this.m_d.Controls.Add(q);
		this.m_d.Controls.Add(r);
		this.m_d.Controls.Add(s);
		this.m_d.Controls.Add(t);
		this.m_d.Controls.Add(u);
		this.m_d.Controls.Add(v);
		this.m_d.Controls.Add(o);
		this.m_d.Controls.Add(p);
		this.m_d.Controls.Add(l);
		this.m_d.Controls.Add(m);
		this.m_d.Controls.Add(n);
		this.m_d.Controls.Add(k);
		this.m_d.Font = new Font("Arial", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		this.m_d.ForeColor = Color.FromArgb(27, 35, 165);
		this.m_d.Location = new Point(12, 92);
		this.m_d.Name = "Lev_Panel";
		this.m_d.Size = new Size(868, 877);
		this.m_d.TabIndex = 2;
		ai.Font = new Font("Verdana", 20.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
		ai.Location = new Point(700, 202);
		ai.Name = "End";
		ai.Size = new Size(126, 37);
		ai.TabIndex = 24;
		ah.Anchor = AnchorStyles.Top;
		ah.AutoSize = true;
		ah.Font = new Font("Arial", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		ah.Location = new Point(551, 84);
		ah.Name = "God";
		ah.Size = new Size(79, 34);
		ah.TabIndex = 23;
		ah.Text = "1988";
		ae.Anchor = AnchorStyles.Top;
		ae.AutoSize = true;
		ae.Font = new Font("Arial", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		ae.Location = new Point(493, 84);
		ae.Name = "Chislo";
		ae.Size = new Size(47, 34);
		ae.TabIndex = 22;
		ae.Text = "25";
		af.Anchor = AnchorStyles.Top;
		af.AutoSize = true;
		af.Font = new Font("Arial", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		af.Location = new Point(436, 84);
		af.Name = "Mes";
		af.Size = new Size(47, 34);
		af.TabIndex = 21;
		af.Text = "12";
		ag.Anchor = AnchorStyles.Top;
		ag.AutoSize = true;
		ag.Font = new Font("Arial", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		ag.Location = new Point(420, 84);
		ag.Name = "NizForDate";
		ag.Size = new Size(227, 34);
		ag.TabIndex = 20;
		ag.Text = "[      /      /          ]";
		ac.Anchor = AnchorStyles.Top;
		ac.AutoSize = true;
		ac.Font = new Font("Arial", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		ac.Location = new Point(551, 50);
		ac.Name = "S";
		ac.Size = new Size(47, 34);
		ac.TabIndex = 19;
		ac.Text = "33";
		ad.Anchor = AnchorStyles.Top;
		ad.AutoSize = true;
		ad.Font = new Font("Arial", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		ad.Location = new Point(493, 50);
		ad.Name = "M";
		ad.Size = new Size(47, 34);
		ad.TabIndex = 18;
		ad.Text = "22";
		ab.Anchor = AnchorStyles.Top;
		ab.AutoSize = true;
		ab.Font = new Font("Arial", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		ab.Location = new Point(436, 50);
		ab.Name = "H";
		ab.Size = new Size(45, 34);
		ab.TabIndex = 17;
		ab.Text = "11";
		aa.Anchor = AnchorStyles.Top;
		aa.AutoSize = true;
		aa.Font = new Font("Arial", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		aa.Location = new Point(420, 50);
		aa.Name = "NizForTime";
		aa.Size = new Size(199, 34);
		aa.TabIndex = 16;
		aa.Text = "[      :      :      ]";
		w.Anchor = AnchorStyles.Top;
		w.AutoSize = true;
		w.Font = new Font("Arial", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		w.Location = new Point(400, 349);
		w.Name = "SATA4_Value";
		w.Size = new Size(97, 34);
		w.TabIndex = 15;
		w.Text = "label4";
		x.Anchor = AnchorStyles.Top;
		x.AutoSize = true;
		x.Font = new Font("Arial", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		x.Location = new Point(400, 315);
		x.Name = "SATA3_Value";
		x.Size = new Size(97, 34);
		x.TabIndex = 14;
		x.Text = "label3";
		y.Anchor = AnchorStyles.Top;
		y.AutoSize = true;
		y.Font = new Font("Arial", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		y.Location = new Point(400, 281);
		y.Name = "SATA2_Value";
		y.Size = new Size(97, 34);
		y.TabIndex = 13;
		y.Text = "label2";
		z.Anchor = AnchorStyles.Top;
		z.AutoSize = true;
		z.Font = new Font("Arial", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		z.Location = new Point(400, 247);
		z.Name = "SATA1_Value";
		z.Size = new Size(97, 34);
		z.TabIndex = 12;
		z.Text = "label1";
		q.AutoSize = true;
		q.Font = new Font("Arial", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		q.Location = new Point(22, 417);
		q.Name = "SysInfo";
		q.Size = new Size(324, 34);
		q.TabIndex = 11;
		q.Text = "► System Information";
		r.AutoSize = true;
		r.Font = new Font("Arial", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		r.Location = new Point(22, 383);
		r.Name = "SATAConf";
		r.Size = new Size(322, 34);
		r.TabIndex = 10;
		r.Text = "► SATA Configuration";
		s.AutoSize = true;
		s.Font = new Font("Arial", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		s.Location = new Point(22, 349);
		s.Name = "SATA4";
		s.Size = new Size(146, 34);
		s.TabIndex = 9;
		s.Text = "► SATA 4";
		t.AutoSize = true;
		t.Font = new Font("Arial", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		t.Location = new Point(22, 315);
		t.Name = "SATA3";
		t.Size = new Size(146, 34);
		t.TabIndex = 8;
		t.Text = "► SATA 3";
		u.AutoSize = true;
		u.Font = new Font("Arial", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		u.Location = new Point(22, 281);
		u.Name = "SATA2";
		u.Size = new Size(146, 34);
		u.TabIndex = 7;
		u.Text = "► SATA 2";
		v.AutoSize = true;
		v.Font = new Font("Arial", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		v.Location = new Point(22, 247);
		v.Name = "SATA1";
		v.Size = new Size(146, 34);
		v.TabIndex = 6;
		v.Text = "► SATA 1";
		o.Anchor = AnchorStyles.Top;
		o.AutoSize = true;
		o.Font = new Font("Arial", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		o.Location = new Point(420, 118);
		o.Name = "LegDisketteA_Value";
		o.Size = new Size(97, 34);
		o.TabIndex = 5;
		o.Text = "label1";
		p.Anchor = AnchorStyles.Top;
		p.AutoSize = true;
		p.Font = new Font("Arial", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		p.Location = new Point(420, 152);
		p.Name = "Language_Value";
		p.Size = new Size(97, 34);
		p.TabIndex = 4;
		p.Text = "label1";
		l.AutoSize = true;
		l.Font = new Font("Arial", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		l.Location = new Point(22, 152);
		l.Name = "Language";
		l.Size = new Size(153, 34);
		l.TabIndex = 3;
		l.Text = "Language";
		m.AutoSize = true;
		m.Font = new Font("Arial", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		m.Location = new Point(22, 118);
		m.Name = "LegDisketteA";
		m.Size = new Size(262, 34);
		m.TabIndex = 2;
		m.Text = "Legacy Diskette A";
		n.AutoSize = true;
		n.Font = new Font("Arial", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		n.Location = new Point(22, 84);
		n.Name = "SysDate";
		n.Size = new Size(189, 34);
		n.TabIndex = 1;
		n.Text = "System Date";
		k.AutoSize = true;
		k.Font = new Font("Arial", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		k.Location = new Point(22, 50);
		k.Name = "SysTime";
		k.Size = new Size(193, 34);
		k.TabIndex = 0;
		k.Text = "System Time";
		e.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		e.AutoScroll = true;
		e.Controls.Add(m_ak);
		e.Controls.Add(aj);
		e.Font = new Font("Arial", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		e.ForeColor = Color.FromArgb(27, 35, 165);
		e.Location = new Point(884, 92);
		e.Name = "Prav_Panel";
		e.Size = new Size(382, 877);
		e.TabIndex = 3;
		m_ak.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		m_ak.BackColor = Color.FromArgb(190, 190, 190);
		m_ak.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		m_ak.ForeColor = Color.FromArgb(27, 35, 165);
		m_ak.Location = new Point(6, 590);
		m_ak.Name = "Help_Niz";
		m_ak.Size = new Size(372, 250);
		m_ak.TabIndex = 1;
		aj.BackColor = Color.FromArgb(190, 190, 190);
		aj.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		aj.ForeColor = Color.FromArgb(27, 35, 165);
		aj.Location = new Point(6, 15);
		aj.Name = "Help_Verh";
		aj.Size = new Size(372, 468);
		aj.TabIndex = 0;
		an.Dock = DockStyle.Bottom;
		an.Image = Resources.NizAll;
		an.Location = new Point(0, 989);
		an.Name = "Niz";
		an.Size = new Size(1280, 35);
		an.SizeMode = PictureBoxSizeMode.StretchImage;
		an.TabIndex = 4;
		an.TabStop = false;
		f.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		f.BackColor = Color.FromArgb(27, 35, 165);
		f.Location = new Point(10, 90);
		f.Name = "Goriz1";
		f.Size = new Size(1260, 2);
		f.TabIndex = 0;
		g.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		g.BackColor = Color.FromArgb(27, 35, 165);
		g.Location = new Point(10, 90);
		g.Name = "Vert1";
		g.Size = new Size(4, 879);
		g.TabIndex = 0;
		h.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		h.BackColor = Color.FromArgb(27, 35, 165);
		h.Location = new Point(880, 90);
		h.Name = "Vert2";
		h.Size = new Size(4, 879);
		h.TabIndex = 1;
		i.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		i.BackColor = Color.FromArgb(27, 35, 165);
		i.Location = new Point(10, 969);
		i.Name = "Goriz2";
		i.Size = new Size(1260, 2);
		i.TabIndex = 1;
		j.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		j.BackColor = Color.FromArgb(27, 35, 165);
		j.Location = new Point(1266, 90);
		j.Name = "Vert3";
		j.Size = new Size(4, 879);
		j.TabIndex = 2;
		al.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		al.BackColor = Color.FromArgb(4, 7, 80);
		al.Cursor = Cursors.Hand;
		al.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Underline, GraphicsUnit.Point, 204);
		al.ForeColor = Color.FromArgb(224, 224, 224);
		al.Location = new Point(1125, 2);
		al.Name = "ShowQuestion";
		al.Size = new Size(155, 30);
		al.TabIndex = 5;
		al.Text = "Напомнить задание";
		al.TextAlign = ContentAlignment.MiddleCenter;
		al.Visible = false;
		al.MouseLeave += a;
		al.Click += c;
		al.MouseEnter += b;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(190, 190, 190);
		base.ClientSize = new Size(1280, 1024);
		base.Controls.Add(al);
		base.Controls.Add(i);
		base.Controls.Add(f);
		base.Controls.Add(an);
		base.Controls.Add(this.m_c);
		base.Controls.Add(am);
		base.Controls.Add(j);
		base.Controls.Add(h);
		base.Controls.Add(g);
		base.Controls.Add(this.m_d);
		base.Controls.Add(e);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "Main_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Main_Form";
		base.WindowState = FormWindowState.Maximized;
		base.FormClosing += a;
		base.KeyDown += a;
		((ISupportInitialize)am).EndInit();
		((ISupportInitialize)this.m_c).EndInit();
		this.m_d.ResumeLayout(performLayout: false);
		this.m_d.PerformLayout();
		e.ResumeLayout(performLayout: false);
		((ISupportInitialize)an).EndInit();
		ResumeLayout(performLayout: false);
	}

	public ak(u A_0)
	{
		ao = A_0;
		c();
		d();
		b();
	}

	public void d()
	{
		if (ao.h)
		{
			al.Visible = true;
		}
		ab.Text = ao.x;
		ad.Text = ao.y;
		ac.Text = ao.z;
		af.Text = ao.ae;
		ae.Text = ao.af;
		ah.Text = ao.ag;
		o.Text = ao.k(ao.ai);
		p.Text = ao.k(ao.al);
		z.Text = ": " + ao.k(ao.ao);
		y.Text = ": " + ao.k(ao.ap);
		x.Text = ": " + ao.k(ao.aq);
		w.Text = ": " + ao.k(ao.ar);
	}

	private void b()
	{
		foreach (Label control in this.m_d.Controls)
		{
			control.ForeColor = ao.g;
		}
		switch (aw)
		{
		case 0:
			aj.Text = ao.aa;
			m_ak.Text = ao.r;
			ay = 0;
			k.ForeColor = Color.White;
			switch (ax)
			{
			case 0:
				ab.ForeColor = Color.White;
				ad.ForeColor = ao.g;
				ac.ForeColor = ao.g;
				break;
			case 1:
				ab.ForeColor = ao.g;
				ad.ForeColor = Color.White;
				ac.ForeColor = ao.g;
				break;
			case 2:
				ab.ForeColor = ao.g;
				ad.ForeColor = ao.g;
				ac.ForeColor = Color.White;
				break;
			}
			break;
		case 1:
			aj.Text = ao.ah;
			m_ak.Text = ao.r;
			ax = 0;
			n.ForeColor = Color.White;
			switch (ay)
			{
			case 0:
				af.ForeColor = Color.White;
				ae.ForeColor = ao.g;
				ah.ForeColor = ao.g;
				break;
			case 1:
				af.ForeColor = ao.g;
				ae.ForeColor = Color.White;
				ah.ForeColor = ao.g;
				break;
			case 2:
				af.ForeColor = ao.g;
				ae.ForeColor = ao.g;
				ah.ForeColor = Color.White;
				break;
			}
			break;
		case 2:
			aj.Text = ao.ak;
			m_ak.Text = ao.o;
			ay = 0;
			m.ForeColor = Color.White;
			o.ForeColor = Color.White;
			break;
		case 3:
			aj.Text = ao.an;
			m_ak.Text = ao.q;
			l.ForeColor = Color.White;
			p.ForeColor = Color.White;
			break;
		case 4:
			aj.Text = ao.@as;
			m_ak.Text = ao.p;
			v.ForeColor = Color.White;
			z.ForeColor = Color.White;
			break;
		case 5:
			aj.Text = ao.@as;
			m_ak.Text = ao.p;
			u.ForeColor = Color.White;
			y.ForeColor = Color.White;
			break;
		case 6:
			aj.Text = ao.@as;
			m_ak.Text = ao.p;
			t.ForeColor = Color.White;
			x.ForeColor = Color.White;
			break;
		case 7:
			aj.Text = ao.@as;
			m_ak.Text = ao.p;
			s.ForeColor = Color.White;
			w.ForeColor = Color.White;
			break;
		case 8:
			aj.Text = ao.@do;
			m_ak.Text = ao.p;
			r.ForeColor = Color.White;
			break;
		case 9:
			aj.Text = "";
			m_ak.Text = ao.p;
			q.ForeColor = Color.White;
			ax = 0;
			ay = 0;
			break;
		}
	}

	private void a()
	{
		switch (aw)
		{
		case 2:
			ap = new ac(ao, ao.ai, ao.aj);
			ap.ShowDialog();
			ao.ai = ao.m;
			break;
		case 3:
			ap = new ac(ao, ao.al, ao.am);
			ap.ShowDialog();
			ao.al = ao.m;
			break;
		case 4:
			aq = new g(ao);
			aq.ShowDialog();
			break;
		case 5:
			ar = new ae(ao);
			ar.ShowDialog();
			break;
		case 6:
			@as = new af(ao);
			@as.ShowDialog();
			break;
		case 7:
			at = new p(ao);
			at.ShowDialog();
			break;
		case 8:
			au = new ah(ao);
			au.ShowDialog();
			break;
		case 9:
			av = new j(ao);
			av.ShowDialog();
			break;
		}
		d();
	}

	private void a(bool A_0)
	{
		switch (aw)
		{
		case 0:
			switch (ax)
			{
			case 0:
				ao.k(ref ao.x, ao.um, A_0);
				break;
			case 1:
				ao.k(ref ao.y, ao.v, A_0);
				break;
			case 2:
				ao.k(ref ao.z, ao.w, A_0);
				break;
			}
			break;
		case 1:
			switch (ay)
			{
			case 0:
				ao.k(ref ao.ae, ao.ab, A_0);
				break;
			case 1:
				ao.k(ref ao.af, ao.ac, A_0);
				break;
			case 2:
				ao.k(ref ao.ag, ao.ad, A_0);
				break;
			}
			break;
		case 2:
			ao.k(ref ao.ai, ao.aj, A_0);
			break;
		}
		d();
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		if (A_1.KeyCode == Keys.Up && aw > 0)
		{
			aw--;
			b();
		}
		else if (A_1.KeyCode == Keys.Down && aw < 9)
		{
			aw++;
			b();
		}
		else if (A_1.KeyCode == Keys.Add || A_1.KeyCode == Keys.Oemplus)
		{
			a(A_0: true);
		}
		else if (A_1.KeyCode == Keys.Subtract || A_1.KeyCode == Keys.OemMinus)
		{
			a(A_0: false);
		}
		else if (A_1.KeyCode == Keys.Left)
		{
			ao.f.Show();
			Hide();
			aw = 0;
			ax = 0;
			ay = 0;
			b();
		}
		else if (A_1.KeyCode == Keys.Right)
		{
			ao.b.Show();
			Hide();
			aw = 0;
			ax = 0;
			ay = 0;
			b();
		}
		else if (A_1.KeyCode == Keys.Return)
		{
			a();
		}
		else if (A_1.KeyCode == Keys.Prior || A_1.KeyCode == Keys.Home)
		{
			aw = 0;
			b();
		}
		else if (A_1.KeyCode == Keys.Next || A_1.KeyCode == Keys.End)
		{
			aw = 9;
			b();
		}
		else if (aw == 0 && A_1.KeyCode == Keys.Tab && A_1.Modifiers != Keys.Shift)
		{
			ax = ((ax < 2) ? (ax + 1) : 0);
			b();
		}
		else if (aw == 1 && A_1.KeyCode == Keys.Tab && A_1.Modifiers != Keys.Shift)
		{
			ay = ((ay < 2) ? (ay + 1) : 0);
			b();
		}
		else if (aw == 0 && A_1.KeyCode == Keys.Tab && A_1.Modifiers == Keys.Shift)
		{
			ax = ((ax > 0) ? (ax - 1) : 2);
			b();
		}
		else if (aw == 1 && A_1.KeyCode == Keys.Tab && A_1.Modifiers == Keys.Shift)
		{
			ay = ((ay > 0) ? (ay - 1) : 2);
			b();
		}
		else if (A_1.KeyCode == Keys.F1)
		{
			ao.ng();
		}
		else if (A_1.KeyCode == Keys.F5)
		{
			ao.na();
		}
		else if (A_1.KeyCode == Keys.F7)
		{
			ao.nd();
		}
		else if (A_1.KeyCode == Keys.F10)
		{
			ao.l();
		}
		else if (A_1.KeyCode == Keys.Escape)
		{
			ao.nf();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		A_1.Cancel = az;
	}

	private void c(object A_0, EventArgs A_1)
	{
		ao.nc();
	}

	private void b(object A_0, EventArgs A_1)
	{
		al.ForeColor = Color.White;
	}

	private void a(object A_0, EventArgs A_1)
	{
		al.ForeColor = Color.FromArgb(224, 224, 224);
	}
}

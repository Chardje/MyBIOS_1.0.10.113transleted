using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MyBIOS.Properties;

public class af : Form
{
	private const int m_a = 6;

	private IContainer m_b;

	private PictureBox m_c;

	private PictureBox m_d;

	private Panel m_e;

	private Panel f;

	private PictureBox g;

	private Panel h;

	private Panel i;

	private Panel j;

	private Panel k;

	private Panel l;

	private Panel m;

	private Label n;

	private Label o;

	private Label p;

	private Label q;

	private Label r;

	private Label s;

	private Label t;

	private Panel u;

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

	private Label m_af;

	private Label ag;

	private Label ah;

	private Label ai;

	private Label aj;

	private Label ak;

	private Label al;

	private Label am;

	private Label an;

	private Label ao;

	private Label ap;

	private Label aq;

	private Label ar;

	private Label @as;

	private Label at;

	private Label au;

	private Label av;

	private Label aw;

	private Label ax;

	private u ay;

	private ac az;

	private int a0;

	private bool a1 = true;

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.m_b != null)
		{
			this.m_b.Dispose();
		}
		base.Dispose(disposing);
	}

	private void e()
	{
		this.m_c = new PictureBox();
		this.m_d = new PictureBox();
		this.m_e = new Panel();
		av = new Label();
		au = new Label();
		al = new Label();
		am = new Label();
		an = new Label();
		ao = new Label();
		ap = new Label();
		aq = new Label();
		ar = new Label();
		@as = new Label();
		at = new Label();
		ak = new Label();
		ae = new Label();
		m_af = new Label();
		ag = new Label();
		ah = new Label();
		ai = new Label();
		aj = new Label();
		x = new Label();
		y = new Label();
		z = new Label();
		aa = new Label();
		ab = new Label();
		ac = new Label();
		ad = new Label();
		v = new Label();
		w = new Label();
		n = new Label();
		o = new Label();
		p = new Label();
		q = new Label();
		r = new Label();
		s = new Label();
		t = new Label();
		m = new Panel();
		u = new Panel();
		f = new Panel();
		aw = new Label();
		ax = new Label();
		g = new PictureBox();
		h = new Panel();
		i = new Panel();
		j = new Panel();
		k = new Panel();
		l = new Panel();
		((ISupportInitialize)this.m_c).BeginInit();
		((ISupportInitialize)this.m_d).BeginInit();
		this.m_e.SuspendLayout();
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
		this.m_d.Image = Resources.MainOnly;
		this.m_d.Location = new Point(0, 35);
		this.m_d.Name = "VerhMenu";
		this.m_d.Size = new Size(1280, 35);
		this.m_d.SizeMode = PictureBoxSizeMode.StretchImage;
		this.m_d.TabIndex = 1;
		this.m_d.TabStop = false;
		this.m_e.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		this.m_e.AutoScroll = true;
		this.m_e.BackColor = Color.FromArgb(190, 190, 190);
		this.m_e.Controls.Add(av);
		this.m_e.Controls.Add(au);
		this.m_e.Controls.Add(al);
		this.m_e.Controls.Add(am);
		this.m_e.Controls.Add(an);
		this.m_e.Controls.Add(ao);
		this.m_e.Controls.Add(ap);
		this.m_e.Controls.Add(aq);
		this.m_e.Controls.Add(ar);
		this.m_e.Controls.Add(@as);
		this.m_e.Controls.Add(at);
		this.m_e.Controls.Add(ak);
		this.m_e.Controls.Add(ae);
		this.m_e.Controls.Add(m_af);
		this.m_e.Controls.Add(ag);
		this.m_e.Controls.Add(ah);
		this.m_e.Controls.Add(ai);
		this.m_e.Controls.Add(aj);
		this.m_e.Controls.Add(x);
		this.m_e.Controls.Add(y);
		this.m_e.Controls.Add(z);
		this.m_e.Controls.Add(aa);
		this.m_e.Controls.Add(ab);
		this.m_e.Controls.Add(ac);
		this.m_e.Controls.Add(ad);
		this.m_e.Controls.Add(v);
		this.m_e.Controls.Add(w);
		this.m_e.Controls.Add(n);
		this.m_e.Controls.Add(o);
		this.m_e.Controls.Add(p);
		this.m_e.Controls.Add(q);
		this.m_e.Controls.Add(r);
		this.m_e.Controls.Add(s);
		this.m_e.Controls.Add(t);
		this.m_e.Controls.Add(m);
		this.m_e.Controls.Add(u);
		this.m_e.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		this.m_e.ForeColor = Color.FromArgb(27, 35, 165);
		this.m_e.Location = new Point(12, 92);
		this.m_e.Name = "Lev_Panel";
		this.m_e.Size = new Size(868, 877);
		this.m_e.TabIndex = 2;
		av.Location = new Point(700, 680);
		av.Name = "End";
		av.Size = new Size(126, 37);
		av.TabIndex = 36;
		au.AutoSize = true;
		au.ForeColor = Color.Black;
		au.Location = new Point(22, 17);
		au.Name = "SATA3";
		au.Size = new Size(109, 34);
		au.TabIndex = 35;
		au.Text = "SATA 3";
		al.AutoSize = true;
		al.ForeColor = Color.FromArgb(64, 64, 64);
		al.Location = new Point(295, 354);
		al.Name = "SMART_INFO_VALUE";
		al.Size = new Size(97, 34);
		al.TabIndex = 34;
		al.Text = "label9";
		am.AutoSize = true;
		am.ForeColor = Color.FromArgb(64, 64, 64);
		am.Location = new Point(192, 320);
		am.Name = "UltraDMA_INFO_VALUE";
		am.Size = new Size(97, 34);
		am.TabIndex = 33;
		am.Text = "label8";
		an.AutoSize = true;
		an.ForeColor = Color.FromArgb(64, 64, 64);
		an.Location = new Point(192, 286);
		an.Name = "AsyncDMA_INFO_VALUE";
		an.Size = new Size(97, 34);
		an.TabIndex = 32;
		an.Text = "label7";
		ao.AutoSize = true;
		ao.ForeColor = Color.FromArgb(64, 64, 64);
		ao.Location = new Point(192, 252);
		ao.Name = "PIOMode_INFO_VALUE";
		ao.Size = new Size(97, 34);
		ao.TabIndex = 31;
		ao.Text = "label6";
		ap.AutoSize = true;
		ap.ForeColor = Color.FromArgb(64, 64, 64);
		ap.Location = new Point(192, 218);
		ap.Name = "Block_INFO_VALUE";
		ap.Size = new Size(97, 34);
		ap.TabIndex = 30;
		ap.Text = "label5";
		aq.AutoSize = true;
		aq.ForeColor = Color.FromArgb(64, 64, 64);
		aq.Location = new Point(192, 184);
		aq.Name = "LBA_INFO_VALUE";
		aq.Size = new Size(97, 34);
		aq.TabIndex = 29;
		aq.Text = "label4";
		ar.AutoSize = true;
		ar.ForeColor = Color.FromArgb(64, 64, 64);
		ar.Location = new Point(192, 150);
		ar.Name = "Size_INFO_VALUE";
		ar.Size = new Size(97, 34);
		ar.TabIndex = 28;
		ar.Text = "label3";
		@as.AutoSize = true;
		@as.ForeColor = Color.FromArgb(64, 64, 64);
		@as.Location = new Point(192, 116);
		@as.Name = "Vendor_INFO_VALUE";
		@as.Size = new Size(97, 34);
		@as.TabIndex = 27;
		@as.Text = "label2";
		at.AutoSize = true;
		at.ForeColor = Color.FromArgb(64, 64, 64);
		at.Location = new Point(192, 82);
		at.Name = "Device_INFO_VALUE";
		at.Size = new Size(97, 34);
		at.TabIndex = 26;
		at.Text = "label1";
		ak.Anchor = AnchorStyles.Top;
		ak.AutoSize = true;
		ak.Location = new Point(492, 631);
		ak.Name = "BitDataTransfer_Value";
		ak.Size = new Size(97, 34);
		ak.TabIndex = 25;
		ak.Text = "label7";
		ae.Anchor = AnchorStyles.Top;
		ae.AutoSize = true;
		ae.Location = new Point(492, 597);
		ae.Name = "SMART_Value";
		ae.Size = new Size(97, 34);
		ae.TabIndex = 24;
		ae.Text = "label6";
		m_af.Anchor = AnchorStyles.Top;
		m_af.AutoSize = true;
		m_af.Location = new Point(492, 563);
		m_af.Name = "DMAMode_Value";
		m_af.Size = new Size(97, 34);
		m_af.TabIndex = 23;
		m_af.Text = "label5";
		ag.Anchor = AnchorStyles.Top;
		ag.AutoSize = true;
		ag.Location = new Point(492, 529);
		ag.Name = "PIOMode_Value";
		ag.Size = new Size(97, 34);
		ag.TabIndex = 22;
		ag.Text = "label4";
		ah.Anchor = AnchorStyles.Top;
		ah.AutoSize = true;
		ah.Location = new Point(492, 495);
		ah.Name = "Block_Value";
		ah.Size = new Size(97, 34);
		ah.TabIndex = 21;
		ah.Text = "label3";
		ai.Anchor = AnchorStyles.Top;
		ai.AutoSize = true;
		ai.Location = new Point(492, 461);
		ai.Name = "LBA_Value";
		ai.Size = new Size(97, 34);
		ai.TabIndex = 20;
		ai.Text = "label2";
		aj.Anchor = AnchorStyles.Top;
		aj.AutoSize = true;
		aj.Location = new Point(492, 427);
		aj.Name = "Type_Value";
		aj.Size = new Size(97, 34);
		aj.TabIndex = 19;
		aj.Text = "label1";
		x.AutoSize = true;
		x.Location = new Point(22, 631);
		x.Name = "BitDataTransfer";
		x.Size = new Size(278, 34);
		x.TabIndex = 18;
		x.Text = "32Bit Data Transfer";
		y.AutoSize = true;
		y.Location = new Point(22, 597);
		y.Name = "SMART";
		y.Size = new Size(277, 34);
		y.TabIndex = 17;
		y.Text = "SMART Monitoring";
		z.AutoSize = true;
		z.Location = new Point(22, 563);
		z.Name = "DMAMode";
		z.Size = new Size(164, 34);
		z.TabIndex = 16;
		z.Text = "DMA Mode";
		aa.AutoSize = true;
		aa.Location = new Point(22, 529);
		aa.Name = "PIOMode";
		aa.Size = new Size(149, 34);
		aa.TabIndex = 15;
		aa.Text = "PIO Mode";
		ab.AutoSize = true;
		ab.Location = new Point(22, 495);
		ab.Name = "Block";
		ab.Size = new Size(404, 34);
		ab.TabIndex = 14;
		ab.Text = "Block(Multi-Sector Transfer)";
		ac.AutoSize = true;
		ac.Location = new Point(22, 461);
		ac.Name = "LBALargeMode";
		ac.Size = new Size(244, 34);
		ac.TabIndex = 13;
		ac.Text = "LBA/Large Mode";
		ad.AutoSize = true;
		ad.Location = new Point(22, 427);
		ad.Name = "Type";
		ad.Size = new Size(81, 34);
		ad.TabIndex = 12;
		ad.Text = "Type";
		v.AutoSize = true;
		v.ForeColor = Color.FromArgb(64, 64, 64);
		v.Location = new Point(22, 354);
		v.Name = "SMART_INFO";
		v.Size = new Size(277, 34);
		v.TabIndex = 11;
		v.Text = "SMART Monitoring";
		w.AutoSize = true;
		w.ForeColor = Color.FromArgb(64, 64, 64);
		w.Location = new Point(22, 320);
		w.Name = "UltraDMA_INFO";
		w.Size = new Size(154, 34);
		w.TabIndex = 10;
		w.Text = "Ultra DMA";
		n.AutoSize = true;
		n.ForeColor = Color.FromArgb(64, 64, 64);
		n.Location = new Point(22, 286);
		n.Name = "AsyncDMA_INFO";
		n.Size = new Size(173, 34);
		n.TabIndex = 9;
		n.Text = "Async DMA";
		o.AutoSize = true;
		o.ForeColor = Color.FromArgb(64, 64, 64);
		o.Location = new Point(22, 252);
		o.Name = "PIOMode_INFO";
		o.Size = new Size(149, 34);
		o.TabIndex = 8;
		o.Text = "PIO Mode";
		p.AutoSize = true;
		p.ForeColor = Color.FromArgb(64, 64, 64);
		p.Location = new Point(22, 218);
		p.Name = "BlockMode_INFO";
		p.Size = new Size(178, 34);
		p.TabIndex = 7;
		p.Text = "Block Mode";
		q.AutoSize = true;
		q.ForeColor = Color.FromArgb(64, 64, 64);
		q.Location = new Point(22, 184);
		q.Name = "LBAMode_INFO";
		q.Size = new Size(156, 34);
		q.TabIndex = 6;
		q.Text = "LBA Mode";
		r.AutoSize = true;
		r.ForeColor = Color.FromArgb(64, 64, 64);
		r.Location = new Point(22, 150);
		r.Name = "Size_INFO";
		r.Size = new Size(73, 34);
		r.TabIndex = 5;
		r.Text = "Size";
		s.AutoSize = true;
		s.ForeColor = Color.FromArgb(64, 64, 64);
		s.Location = new Point(22, 116);
		s.Name = "Vendor_INFO";
		s.Size = new Size(113, 34);
		s.TabIndex = 4;
		s.Text = "Vendor";
		t.AutoSize = true;
		t.ForeColor = Color.FromArgb(64, 64, 64);
		t.Location = new Point(22, 82);
		t.Name = "Device_INFO";
		t.Size = new Size(109, 34);
		t.TabIndex = 3;
		t.Text = "Device";
		m.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		m.BackColor = Color.FromArgb(27, 35, 165);
		m.Location = new Point(18, 68);
		m.Name = "Goriz_1";
		m.Size = new Size(828, 2);
		m.TabIndex = 1;
		u.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		u.BackColor = Color.FromArgb(27, 35, 165);
		u.Location = new Point(18, 408);
		u.Name = "Goriz_2";
		u.Size = new Size(828, 2);
		u.TabIndex = 2;
		f.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		f.AutoScroll = true;
		f.Controls.Add(aw);
		f.Controls.Add(ax);
		f.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		f.ForeColor = Color.FromArgb(27, 35, 165);
		f.Location = new Point(884, 92);
		f.Name = "Prav_Panel";
		f.Size = new Size(382, 877);
		f.TabIndex = 3;
		aw.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		aw.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		aw.ForeColor = Color.FromArgb(27, 35, 165);
		aw.Location = new Point(6, 590);
		aw.Name = "Help_Niz";
		aw.Size = new Size(372, 250);
		aw.TabIndex = 0;
		ax.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		ax.ForeColor = Color.FromArgb(27, 35, 165);
		ax.Location = new Point(6, 15);
		ax.Name = "Help_Verh";
		ax.Size = new Size(372, 470);
		ax.TabIndex = 1;
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
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(190, 190, 190);
		base.ClientSize = new Size(1280, 1024);
		base.Controls.Add(k);
		base.Controls.Add(h);
		base.Controls.Add(g);
		base.Controls.Add(this.m_d);
		base.Controls.Add(this.m_c);
		base.Controls.Add(l);
		base.Controls.Add(j);
		base.Controls.Add(i);
		base.Controls.Add(this.m_e);
		base.Controls.Add(f);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "Main_SATA3_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Main_SATA3_Form";
		base.WindowState = FormWindowState.Maximized;
		base.FormClosing += a;
		base.KeyDown += a;
		((ISupportInitialize)this.m_c).EndInit();
		((ISupportInitialize)this.m_d).EndInit();
		this.m_e.ResumeLayout(performLayout: false);
		this.m_e.PerformLayout();
		f.ResumeLayout(performLayout: false);
		((ISupportInitialize)g).EndInit();
		ResumeLayout(performLayout: false);
	}

	public af(u A_0)
	{
		ay = A_0;
		e();
		d();
		b();
	}

	private void d()
	{
		if (ay.cf == "Not Installed")
		{
			ay.aq = (ay.b6 = "Not Detected");
			ac.Visible = false;
			ai.Visible = false;
			ab.Visible = false;
			ah.Visible = false;
			aa.Visible = false;
			ag.Visible = false;
			z.Visible = false;
			m_af.Visible = false;
			y.Visible = false;
			ae.Visible = false;
			x.Visible = false;
			ak.Visible = false;
		}
		else
		{
			if (ay.b5)
			{
				ay.aq = "ST3250824AS";
				ay.b6 = "Hard Disk";
			}
			ac.Visible = true;
			ai.Visible = true;
			ab.Visible = true;
			ah.Visible = true;
			aa.Visible = true;
			ag.Visible = true;
			z.Visible = true;
			m_af.Visible = true;
			y.Visible = true;
			ae.Visible = true;
			x.Visible = true;
			ak.Visible = true;
		}
		int num = ad.Location.X;
		int num2 = aj.Location.X;
		int num3 = 0;
		if (ay.b6 == "Not Detected")
		{
			num3 = 150;
			s.Visible = false;
			@as.Visible = false;
			r.Visible = false;
			ar.Visible = false;
			q.Visible = false;
			aq.Visible = false;
			p.Visible = false;
			ap.Visible = false;
			o.Visible = false;
			ao.Visible = false;
			n.Visible = false;
			an.Visible = false;
			w.Visible = false;
			am.Visible = false;
			v.Visible = false;
			al.Visible = false;
			u.Location = new Point(18, 130);
		}
		else
		{
			num3 = 427;
			s.Visible = true;
			@as.Visible = true;
			r.Visible = true;
			ar.Visible = true;
			q.Visible = true;
			aq.Visible = true;
			p.Visible = true;
			ap.Visible = true;
			o.Visible = true;
			ao.Visible = true;
			n.Visible = true;
			an.Visible = true;
			w.Visible = true;
			am.Visible = true;
			v.Visible = true;
			al.Visible = true;
			u.Location = new Point(18, 408);
		}
		ad.Location = new Point(num, num3);
		aj.Location = new Point(num2, num3);
		ac.Location = new Point(num, num3 += 34);
		ai.Location = new Point(num2, num3);
		ab.Location = new Point(num, num3 += 34);
		ah.Location = new Point(num2, num3);
		aa.Location = new Point(num, num3 += 34);
		ag.Location = new Point(num2, num3);
		z.Location = new Point(num, num3 += 34);
		m_af.Location = new Point(num2, num3);
		y.Location = new Point(num, num3 += 34);
		ae.Location = new Point(num2, num3);
		x.Location = new Point(num, num3 += 34);
		ak.Location = new Point(num2, num3);
		at.Text = ":" + ay.b6;
		@as.Text = ":" + ay.b7;
		ar.Text = ":" + ay.b8;
		aq.Text = ":" + ay.b9;
		ap.Text = ":" + ay.ca;
		ao.Text = ":" + ay.cb;
		an.Text = ":" + ay.cc;
		am.Text = ":" + ay.cd;
		al.Text = ":" + ay.ce;
		aj.Text = ay.k(ay.cf);
		ai.Text = ay.k(ay.ch);
		ah.Text = ay.k(ay.cj);
		ag.Text = ay.k(ay.cl);
		m_af.Text = ay.k(ay.cn);
		ae.Text = ay.k(ay.cp);
		ak.Text = ay.k(ay.cr);
		aw.Text = ay.o;
		c();
	}

	private void c()
	{
		if (a0 < 3)
		{
			this.m_e.ScrollControlIntoView(au);
		}
		else
		{
			this.m_e.ScrollControlIntoView(x);
		}
	}

	private void b()
	{
		if (ay.cf == "Not Installed" && a0 != 0)
		{
			a0 = 0;
			return;
		}
		ad.ForeColor = ay.g;
		aj.ForeColor = ay.g;
		ac.ForeColor = ay.g;
		ai.ForeColor = ay.g;
		ab.ForeColor = ay.g;
		ah.ForeColor = ay.g;
		aa.ForeColor = ay.g;
		ag.ForeColor = ay.g;
		z.ForeColor = ay.g;
		m_af.ForeColor = ay.g;
		y.ForeColor = ay.g;
		ae.ForeColor = ay.g;
		x.ForeColor = ay.g;
		ak.ForeColor = ay.g;
		switch (a0)
		{
		case 0:
			ax.Text = ay.dh;
			ad.ForeColor = Color.White;
			aj.ForeColor = Color.White;
			break;
		case 1:
			ax.Text = ay.di;
			ac.ForeColor = Color.White;
			ai.ForeColor = Color.White;
			break;
		case 2:
			ax.Text = ay.dj;
			ab.ForeColor = Color.White;
			ah.ForeColor = Color.White;
			break;
		case 3:
			ax.Text = ay.dk;
			aa.ForeColor = Color.White;
			ag.ForeColor = Color.White;
			break;
		case 4:
			ax.Text = ay.dl;
			z.ForeColor = Color.White;
			m_af.ForeColor = Color.White;
			break;
		case 5:
			ax.Text = ay.dm;
			y.ForeColor = Color.White;
			ae.ForeColor = Color.White;
			break;
		case 6:
			ax.Text = ay.dn;
			x.ForeColor = Color.White;
			ak.ForeColor = Color.White;
			break;
		}
		c();
	}

	private void a()
	{
		switch (a0)
		{
		case 0:
			az = new ac(ay, ay.cf, ay.cg);
			az.ShowDialog();
			ay.cf = ay.m;
			break;
		case 1:
			az = new ac(ay, ay.ch, ay.ci);
			az.ShowDialog();
			ay.ch = ay.m;
			break;
		case 2:
			az = new ac(ay, ay.cj, ay.ck);
			az.ShowDialog();
			ay.cj = ay.m;
			break;
		case 3:
			az = new ac(ay, ay.cl, ay.cm);
			az.ShowDialog();
			ay.cl = ay.m;
			break;
		case 4:
			az = new ac(ay, ay.cn, ay.co);
			az.ShowDialog();
			ay.cn = ay.m;
			break;
		case 5:
			az = new ac(ay, ay.cp, ay.cq);
			az.ShowDialog();
			ay.cp = ay.m;
			break;
		case 6:
			az = new ac(ay, ay.cr, ay.cs);
			az.ShowDialog();
			ay.cr = ay.m;
			break;
		}
		d();
	}

	private void a(bool A_0)
	{
		switch (a0)
		{
		case 0:
			ay.k(ref ay.cf, ay.cg, A_0);
			break;
		case 1:
			ay.k(ref ay.ch, ay.ci, A_0);
			break;
		case 2:
			ay.k(ref ay.cj, ay.ck, A_0);
			break;
		case 3:
			ay.k(ref ay.cl, ay.cm, A_0);
			break;
		case 4:
			ay.k(ref ay.cn, ay.co, A_0);
			break;
		case 5:
			ay.k(ref ay.cp, ay.cq, A_0);
			break;
		case 6:
			ay.k(ref ay.cr, ay.cs, A_0);
			break;
		}
		d();
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		if (A_1.KeyCode == Keys.Escape)
		{
			a1 = false;
			Close();
		}
		else if (A_1.KeyCode == Keys.Up && a0 > 0)
		{
			a0--;
			b();
		}
		else if (A_1.KeyCode == Keys.Down && a0 < 6)
		{
			a0++;
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
		else if (A_1.KeyCode == Keys.Return)
		{
			a();
		}
		else if (A_1.KeyCode == Keys.Prior || A_1.KeyCode == Keys.Home)
		{
			a0 = 0;
			b();
		}
		else if (A_1.KeyCode == Keys.Next || A_1.KeyCode == Keys.End)
		{
			a0 = 6;
			b();
		}
		else if (A_1.KeyCode == Keys.F1)
		{
			ay.ng();
		}
		else if (A_1.KeyCode == Keys.F5)
		{
			ay.na();
			d();
		}
		else if (A_1.KeyCode == Keys.F7)
		{
			ay.nd();
			d();
		}
		else if (A_1.KeyCode == Keys.F10)
		{
			ay.l();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		A_1.Cancel = a1;
	}
}

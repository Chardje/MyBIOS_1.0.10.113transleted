using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MyBIOS.Properties;

public class aa : Form
{
	private u m_a;

	private ac m_b;

	private bool c = true;

	private IContainer d;

	private PictureBox e;

	private PictureBox f;

	private Panel g;

	private Panel h;

	private PictureBox i;

	private Panel j;

	private Panel k;

	private Panel l;

	private Panel m;

	private Panel n;

	private Panel o;

	private Label p;

	private Label q;

	private Label r;

	private Label s;

	private Label t;

	private Label u;

	private Label v;

	public aa(u A_0)
	{
		this.m_a = A_0;
		a();
		b();
	}

	private void b()
	{
		s.Text = this.m_a.k(this.m_a.jd);
		v.Text = this.m_a.jf;
		u.Text = this.m_a.o;
	}

	private void a(bool A_0)
	{
		this.m_a.k(ref this.m_a.jd, this.m_a.je, A_0);
		b();
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
        Debug.WriteLine(A_1.KeyCode);

        if (A_1.KeyCode == Keys.Escape)
		{
			c = false;
			Close();
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
			this.m_b = new ac(this.m_a, this.m_a.jd, this.m_a.je);
			this.m_b.ShowDialog();
			this.m_a.jd = this.m_a.m;
			b();
		}
		else if (A_1.KeyCode == Keys.F1)
		{
			this.m_a.ng();
		}
		else if (A_1.KeyCode == Keys.F5)
		{
			this.m_a.na();
			b();
		}
		else if (A_1.KeyCode == Keys.F7)
		{
			this.m_a.nd();
			b();
		}
		else if (A_1.KeyCode == Keys.F10)
		{
			this.m_a.l();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		A_1.Cancel = c;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && d != null)
		{
			d.Dispose();
		}
		base.Dispose(disposing);
	}

	private void a()
	{
		e = new PictureBox();
		f = new PictureBox();
		g = new Panel();
		s = new Label();
		t = new Label();
		r = new Label();
		q = new Label();
		p = new Label();
		o = new Panel();
		h = new Panel();
		u = new Label();
		v = new Label();
		i = new PictureBox();
		j = new Panel();
		k = new Panel();
		l = new Panel();
		m = new Panel();
		n = new Panel();
		((ISupportInitialize)e).BeginInit();
		((ISupportInitialize)f).BeginInit();
		g.SuspendLayout();
		h.SuspendLayout();
		((ISupportInitialize)i).BeginInit();
		SuspendLayout();
		e.Dock = DockStyle.Top;
		e.Image = Resources.ShapkaAll;
		e.Location = new Point(0, 0);
		e.Name = "Shapka";
		e.Size = new Size(1280, 35);
		e.SizeMode = PictureBoxSizeMode.StretchImage;
		e.TabIndex = 0;
		e.TabStop = false;
		f.Dock = DockStyle.Top;
		f.Image = Resources.AdvancedOnly;
		f.Location = new Point(0, 35);
		f.Name = "VerhMenu";
		f.Size = new Size(1280, 35);
		f.SizeMode = PictureBoxSizeMode.StretchImage;
		f.TabIndex = 1;
		f.TabStop = false;
		g.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		g.AutoScroll = true;
		g.BackColor = Color.FromArgb(190, 190, 190);
		g.Controls.Add(s);
		g.Controls.Add(t);
		g.Controls.Add(r);
		g.Controls.Add(q);
		g.Controls.Add(p);
		g.Controls.Add(o);
		g.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		g.ForeColor = Color.FromArgb(27, 35, 165);
		g.Location = new Point(12, 92);
		g.Name = "Lev_Panel";
		g.Size = new Size(868, 877);
		g.TabIndex = 2;
		s.Anchor = AnchorStyles.Top;
		s.AutoSize = true;
		s.ForeColor = Color.White;
		s.Location = new Point(446, 186);
		s.Name = "PlugAndPlayOS_Value";
		s.Size = new Size(97, 34);
		s.TabIndex = 39;
		s.Text = "label1";
		t.AutoSize = true;
		t.ForeColor = Color.White;
		t.Location = new Point(22, 186);
		t.Name = "PlugAndPlayOS";
		t.Size = new Size(264, 34);
		t.TabIndex = 38;
		t.Text = "Plug And Play O/S";
		r.AutoSize = true;
		r.ForeColor = Color.Black;
		r.Location = new Point(179, 85);
		r.Name = "Warning_INFO_Value";
		r.Size = new Size(560, 68);
		r.TabIndex = 37;
		r.Text = "Setting wrong values in below sections\r\nmay cause system to malfunction.";
		q.AutoSize = true;
		q.ForeColor = Color.Black;
		q.Location = new Point(22, 85);
		q.Name = "Warning_INFO";
		q.Size = new Size(163, 34);
		q.TabIndex = 36;
		q.Text = "WARNING:";
		p.AutoSize = true;
		p.ForeColor = Color.Black;
		p.Location = new Point(22, 17);
		p.Name = "AdvancedPCIPnPSettings_shapka";
		p.Size = new Size(395, 34);
		p.TabIndex = 35;
		p.Text = "Advanced PCI/PnP Settings";
		o.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		o.BackColor = Color.FromArgb(27, 35, 165);
		o.Location = new Point(18, 68);
		o.Name = "Goriz_1";
		o.Size = new Size(828, 2);
		o.TabIndex = 1;
		h.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		h.AutoScroll = true;
		h.Controls.Add(u);
		h.Controls.Add(v);
		h.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		h.ForeColor = Color.FromArgb(27, 35, 165);
		h.Location = new Point(884, 92);
		h.Name = "Prav_Panel";
		h.Size = new Size(382, 877);
		h.TabIndex = 3;
		u.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		u.Location = new Point(6, 590);
		u.Name = "Help_Niz";
		u.Size = new Size(372, 250);
		u.TabIndex = 1;
		v.Location = new Point(6, 15);
		v.Name = "Help_Verh";
		v.Size = new Size(372, 470);
		v.TabIndex = 0;
		i.Dock = DockStyle.Bottom;
		i.Image = Resources.NizAll;
		i.Location = new Point(0, 989);
		i.Name = "Niz";
		i.Size = new Size(1280, 35);
		i.SizeMode = PictureBoxSizeMode.StretchImage;
		i.TabIndex = 4;
		i.TabStop = false;
		j.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		j.BackColor = Color.FromArgb(27, 35, 165);
		j.Location = new Point(10, 90);
		j.Name = "Goriz1";
		j.Size = new Size(1260, 2);
		j.TabIndex = 0;
		k.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		k.BackColor = Color.FromArgb(27, 35, 165);
		k.Location = new Point(10, 90);
		k.Name = "Vert1";
		k.Size = new Size(4, 879);
		k.TabIndex = 0;
		l.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		l.BackColor = Color.FromArgb(27, 35, 165);
		l.Location = new Point(880, 90);
		l.Name = "Vert2";
		l.Size = new Size(4, 879);
		l.TabIndex = 1;
		m.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		m.BackColor = Color.FromArgb(27, 35, 165);
		m.Location = new Point(10, 969);
		m.Name = "Goriz2";
		m.Size = new Size(1260, 2);
		m.TabIndex = 1;
		n.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		n.BackColor = Color.FromArgb(27, 35, 165);
		n.Location = new Point(1266, 90);
		n.Name = "Vert3";
		n.Size = new Size(4, 879);
		n.TabIndex = 2;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(190, 190, 190);
		base.ClientSize = new Size(1280, 1024);
		base.Controls.Add(m);
		base.Controls.Add(j);
		base.Controls.Add(i);
		base.Controls.Add(f);
		base.Controls.Add(e);
		base.Controls.Add(n);
		base.Controls.Add(l);
		base.Controls.Add(k);
		base.Controls.Add(g);
		base.Controls.Add(h);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "Advanced_PCIPnP_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Advanced_PCIPnP_Form";
		base.WindowState = FormWindowState.Maximized;
		base.FormClosing += a;
		base.KeyDown += a;
		((ISupportInitialize)e).EndInit();
		((ISupportInitialize)f).EndInit();
		g.ResumeLayout(performLayout: false);
		g.PerformLayout();
		h.ResumeLayout(performLayout: false);
		((ISupportInitialize)i).EndInit();
		ResumeLayout(performLayout: false);
	}
}

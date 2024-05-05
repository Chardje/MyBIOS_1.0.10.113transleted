using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class i : Form
{
	private bool m_a = true;

	private IContainer b;

	private Label c;

	private Panel d;

	private Panel e;

	private Panel f;

	private Panel g;

	private Panel h;

	private Label m_i;

	private Label j;

	public i()
	{
		a();
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		if (A_1.KeyCode == Keys.Escape)
		{
			this.m_a = false;
			Close();
		}
		else if (A_1.KeyCode == Keys.Return)
		{
			this.m_a = false;
			Close();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		A_1.Cancel = this.m_a;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && b != null)
		{
			b.Dispose();
		}
		base.Dispose(disposing);
	}

	private void a()
	{
		c = new Label();
		d = new Panel();
		e = new Panel();
		f = new Panel();
		g = new Panel();
		h = new Panel();
		m_i = new Label();
		j = new Label();
		SuspendLayout();
		c.Font = new Font("Arial", 18f, FontStyle.Bold, GraphicsUnit.Point, 204);
		c.ForeColor = Color.FromArgb(27, 35, 165);
		c.Location = new Point(35, 72);
		c.Name = "MyLabel_Lev";
		c.Size = new Size(343, 206);
		c.TabIndex = 7;
		c.Text = "General Help\r\n←→      Select Screen\r\n+-          Change Option/Field\r\nPGDN   Next Page\r\nHOME   Go to Top of Screen\r\nF5         Load Defaults\r\nF10       Save and Exit";
		d.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		d.BackColor = Color.FromArgb(27, 35, 165);
		d.Location = new Point(12, 325);
		d.Name = "Goriz2";
		d.Size = new Size(796, 3);
		d.TabIndex = 1;
		e.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		e.BackColor = Color.FromArgb(27, 35, 165);
		e.Location = new Point(12, 22);
		e.Name = "Goriz1";
		e.Size = new Size(796, 3);
		e.TabIndex = 2;
		f.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		f.BackColor = Color.FromArgb(27, 35, 165);
		f.Location = new Point(12, 393);
		f.Name = "Goriz3";
		f.Size = new Size(796, 3);
		f.TabIndex = 3;
		g.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		g.BackColor = Color.FromArgb(27, 35, 165);
		g.Location = new Point(12, 22);
		g.Name = "Vert1";
		g.Size = new Size(3, 373);
		g.TabIndex = 5;
		h.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		h.BackColor = Color.FromArgb(27, 35, 165);
		h.Location = new Point(805, 22);
		h.Name = "Vert2";
		h.Size = new Size(3, 373);
		h.TabIndex = 6;
		m_i.Anchor = AnchorStyles.Top;
		m_i.BackColor = Color.Black;
		m_i.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		m_i.ForeColor = Color.FromArgb(190, 190, 190);
		m_i.Location = new Point(373, 341);
		m_i.Name = "Ok_But";
		m_i.Size = new Size(75, 38);
		m_i.TabIndex = 9;
		m_i.Text = "[Ok]";
		m_i.TextAlign = ContentAlignment.TopCenter;
		j.Font = new Font("Arial", 18f, FontStyle.Bold, GraphicsUnit.Point, 204);
		j.ForeColor = Color.FromArgb(27, 35, 165);
		j.Location = new Point(408, 72);
		j.Name = "MyLabel_Prav";
		j.Size = new Size(380, 206);
		j.TabIndex = 10;
		j.Text = "\r\n↑↓         Select Item\r\nEnter    Go to Sub Screen\r\nPGUP   Previous Page\r\nEND      Go to Bottom of Screen\r\nF7         Discard Changes\r\nESC      Exit";
		base.AutoScaleDimensions = new SizeF(19f, 37f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoScroll = true;
		BackColor = Color.White;
		base.ClientSize = new Size(820, 418);
		base.Controls.Add(d);
		base.Controls.Add(j);
		base.Controls.Add(c);
		base.Controls.Add(m_i);
		base.Controls.Add(h);
		base.Controls.Add(g);
		base.Controls.Add(f);
		base.Controls.Add(e);
		Font = new Font("Arial", 24f, FontStyle.Bold, GraphicsUnit.Point, 204);
		ForeColor = Color.FromArgb(190, 190, 190);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(10, 9, 10, 9);
		base.Name = "GeneralHelp_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "GeneralHelp_Form";
		base.FormClosing += a;
		base.KeyDown += a;
		ResumeLayout(performLayout: false);
	}
}

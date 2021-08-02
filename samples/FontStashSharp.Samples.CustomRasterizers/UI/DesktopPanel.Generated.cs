/* Generated by MyraPad at 7/26/2021 11:21:59 AM */
using Myra;
using Myra.Graphics2D;
using Myra.Graphics2D.TextureAtlases;
using Myra.Graphics2D.UI;
using Myra.Graphics2D.Brushes;
using Myra.Graphics2D.UI.Properties;

#if MONOGAME || FNA
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#elif STRIDE
using Stride.Core.Mathematics;
#else
using System.Drawing;
using System.Numerics;
#endif

namespace FontStashSharp.Samples.UI
{
	partial class DesktopPanel: VerticalStackPanel
	{
		private void BuildUI()
		{
			_labelHeader = new Label();
			_labelHeader.Text = "StbTrueTypeSharp(default)";
			_labelHeader.Id = "_labelHeader";

			var horizontalSeparator1 = new HorizontalSeparator();

			_labelText = new Label();
			_labelText.Text = "The quick brown\\nfox jumps\\nover the lazy dog";
			_labelText.Id = "_labelText";

			
			Widgets.Add(_labelHeader);
			Widgets.Add(horizontalSeparator1);
			Widgets.Add(_labelText);
		}

		
		public Label _labelHeader;
		public Label _labelText;
	}
}
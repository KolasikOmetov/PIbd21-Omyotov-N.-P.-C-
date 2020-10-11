using System.Drawing;

namespace BusWithGarmoshka
{
	class Bus : Vehicle
	{
		protected readonly int busWidth = 150;
		protected readonly int busHeight = 60;
		public Bus(int maxSpeed, float weight, Color mainColor)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
		}

		protected Bus(int maxSpeed, float weight, Color mainColor, int busWidth, int busHeight)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			this.busWidth = busWidth;
			this.busHeight = busHeight;
		}
		public override void MoveTransport(Direction direction)
		{
			float step = MaxSpeed * 100 / Weight;
			switch (direction)
			{
				// вправо
				case Direction.Right:
					if (_startPosX + step < _pictureWidth - busWidth)
					{
						_startPosX += step;
					}
					break;
				//влево
				case Direction.Left:
					if (_startPosX - step > 0)
					{
						_startPosX -= step;
					}
					break;
				//вверх
				case Direction.Up:
					if (_startPosY - step > 0)
					{
						_startPosY -= step;
					}
					break;
				//вниз
				case Direction.Down:
					if (_startPosY + step < _pictureHeight - busHeight)
					{
						_startPosY += step;
					}
					break;
			}
		}

		public override void DrawTransport(Graphics g)
		{
			{
				Brush cusov = new SolidBrush(MainColor);
				g.FillRectangle(cusov, _startPosX, _startPosY, 150, 50);
				Brush door = new SolidBrush(Color.Yellow);
				g.FillRectangle(door, _startPosX, _startPosY + 5, 10, 25);
				g.FillRectangle(door, _startPosX, _startPosY + 40, 5, 5);
				g.FillRectangle(door, _startPosX + 25, _startPosY + 5, 25, 40);
				Brush pen = new SolidBrush(Color.Black);
				g.FillEllipse(pen, _startPosX + 5, _startPosY + 40, 20, 20);
				g.FillEllipse(pen, _startPosX + 120, _startPosY + 40, 20, 20);

			}
		}
	}
}

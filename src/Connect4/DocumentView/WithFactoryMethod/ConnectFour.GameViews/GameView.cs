using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour.GameViews;

public abstract class GameView
{
    public abstract void Start();
    public abstract void Play();
    public abstract bool IsResume();
}

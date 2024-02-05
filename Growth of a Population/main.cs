using System;

class Arge {
    
    public static int NbYear(int p0, double percent, int aug, int p) {
      int y = 0;
      while(p0 < p)
      {
        p0 = (int)(p0 + (p0 * percent/100) + aug);
        y++;
      }
      return y;
    }
}
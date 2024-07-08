namespace PhysiSharp.Models
{
   public class Vector
   {

      #region Constants

      private const int MaxAngle = 360;
      private const int MinAngle = 0;

      #endregion

      #region Properties

      private int _direction;

      public int Direction
      {
         get => _direction;
         set => NormalizeDirection(value);
      }

      public decimal Magnitude;

      #endregion

      public Vector() {}

      public Vector(int direction, decimal magnitude)
      {
         Direction = direction;
         Magnitude = magnitude;
      }


      #region Methods

      private int NormalizeDirection(int angle)
      {
         while(angle < MinAngle || angle > MaxAngle);
            
         return angle;
      }

      #endregion
   }
}

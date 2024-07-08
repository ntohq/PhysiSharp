namespace PhysiSharp.Models
{
   /// <summary>
   /// Models a physical force extered upon an object on a 2D plane.
   /// </summary>
   public class Force : Vector
   {
      #region Properties

      #endregion

      public Force() : base() {}

      public Force(int direction, decimal magnitude) : base(direction, magnitude){}

      #region OverloadedOperators


      #endregion
   }
}

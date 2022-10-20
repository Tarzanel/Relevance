
namespace Rucsac.Articole
{
    public class ArticolInventar
    {
        public float greutate { get; set; }
        public float volum { get; set; }

        public ArticolInventar(float greutate, float volum)
        {
            this.greutate = greutate;
            this.volum = volum;
        }
    }
}

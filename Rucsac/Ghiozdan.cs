using Rucsac.Articole;


namespace Rucsac
{
    public class Ghiozdan
    {
        public ArticolInventar[] Inventar { get; set; }

        private float GreutateMaxima { get; set; }
        private float VolumMaxim { get; set; }

        private float greutateCurenta = 0f;
        private float volumCurent = 0f;
        public int nrCurentArticole = 0;


        public Ghiozdan(float greutateMaxima, float volumMaxim, int nrArticole)
        {
            Inventar = new ArticolInventar[nrArticole];
            GreutateMaxima = greutateMaxima;
            VolumMaxim = volumMaxim;

        }

        /// <summary>
        /// Adauga articole in ghiozdan
        /// </summary>
        /// <param name="articol"></param>
        /// <returns></returns>
        public bool Adauga(ArticolInventar articol)
        {
            CalculStareCurenta();
            if (nrCurentArticole == Inventar.Length)
            {
                return false;
            }
            if((greutateCurenta + articol.greutate) > GreutateMaxima || (volumCurent + articol.volum) > VolumMaxim )
            {
                return false;
            }
            Inventar[nrCurentArticole] = articol;
            nrCurentArticole++;
            return true;
        }

        /// <summary>
        /// Calculeaza starea curenta a ghiozdanului; greutate si volum curente
        /// </summary>
        public void CalculStareCurenta()
        {
            greutateCurenta = 0f;
            volumCurent = 0f;
            for(int i = 0; i < Inventar.Length; i++)
            {
                if (Inventar[i] != null)
                {
                    greutateCurenta += Inventar[i].greutate;
                    volumCurent += Inventar[i].volum;
                }
            }
        }

        public override string ToString()
        {
            CalculStareCurenta();
            return $"Stare ghiozdan : \n Articole: {nrCurentArticole} Greutate: {greutateCurenta} Volum: {volumCurent}";
        }
    }
}

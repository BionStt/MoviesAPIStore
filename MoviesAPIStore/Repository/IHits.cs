using MoviesAPIStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPIStore.Repository
{
    public interface IHits
    {
        List<HitsTB> GetHitsList();
        List<string> GetChartsMoviesreport();
        List<string> GetChartsMusicreport();
    }
}

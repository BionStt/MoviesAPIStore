using MoviesAPIStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPIStore.Repository
{
    public interface IAPIManager
    {
        int isApikeyAlreadyGenerated(int? ServiceID, int? UserID);

        int GenerateandSaveToken(APIManagerTB APIManagerTB);

        APIManagerVM GetApiDetailsbyServiceIDandUserID(int? ServiceID, int? UserID);

        int DeactivateService(int? ServiceID, int? UserID);

        int ReactivateService(int? ServiceID, int? UserID);

        
    }
}

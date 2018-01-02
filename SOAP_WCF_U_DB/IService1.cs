﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SOAP_WCF_U_DB
{
    //til eksamen
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<Movie> GetMovie();

        [OperationContract]
        void AddMovie(Movie newFilm);

        [OperationContract]
        void DeleteMovie(Movie deleteFilm);

        [OperationContract]
        void UpdateMovie(int id, Movie film);


    }

}

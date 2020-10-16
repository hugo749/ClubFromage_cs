using System;
using System.Collections.Generic;
using System.Text;
using model.business;
using model.data;

namespace model.business
{
    class fromage
    {
        private int _id;
        private int _paysorigineid;
        private string _nom;
        private string _creation;
        private string _image;

        public fromage (int id, int paysorigineid, string nom, string creation, string image)
        {
            _id=id;
            _paysorigineid=paysorigineid;
            _nom=nom;
            _creation=creation;
            _image=image;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public int Paysorigineid { get => _paysorigineid; set => _paysorigineid = value; }
        public string Creation { get => _creation; set => _creation = value; }
        public string Image { get => _image; set => _image = value; }
    }
    
}
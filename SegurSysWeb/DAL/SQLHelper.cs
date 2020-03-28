using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface SQLHelper<QualquerClasse>
    {
        void create(QualquerClasse obj);
        bool find(QualquerClasse obj);
        List<QualquerClasse> findAll();


    }
}

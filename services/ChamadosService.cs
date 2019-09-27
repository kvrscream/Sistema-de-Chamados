using avaliacao.Data;
using avaliacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace avaliacao.services
{
    public class ChamadosService
    {
        private ApplicationDbContext _context;
        public ChamadosService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Chamados GetSingleChamado(int Id)
        {
            Chamados chamado = new Chamados();

            try
            {
                chamado = _context.Chamados.Where(w => w.Id == Id).FirstOrDefault();
            } catch(Exception ex)
            {
                throw ex;
            }

            return chamado;
        }

        public List<Chamados> GetAllChamados()
        {
            List<Chamados> chamados = new List<Chamados>();

            try
            {
                chamados = _context.Chamados.ToList();
            } catch(Exception ex)
            {
                throw ex;
            }

            return chamados;
        }


        public Dictionary<string, string> Create(Chamados chamado)
        {
            Dictionary<string, string> retorno = new Dictionary<string, string>();

            try
            {
                _context.Chamados.Add(chamado);
                _context.SaveChanges();
            } catch(Exception ex)
            {
                retorno.Add("Não foi possível abrir o chamado no momento!", "Motivo: " + ex.ToString());
            }

            return retorno;
        }


        public Dictionary<string, string> Edit(Chamados chamado)
        {
            Dictionary<string, string> retorno = new Dictionary<string, string>();

            try
            {
                _context.Update(chamado);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                retorno.Add("Não foi possível fechar o chamado no momento!", "Motivo: " + ex.ToString());
            }

            return retorno;
        }


    }
}

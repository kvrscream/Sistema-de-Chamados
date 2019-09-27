using avaliacao.Data;
using avaliacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace avaliacao.services
{
    public class ClienteService
    {

        private ApplicationDbContext _context;

        public ClienteService(ApplicationDbContext context)
        {
            _context = context;
        }


        public Cliente GetSingleClient(int Id)
        {
            Cliente client = null;

            client = _context.Clientes.Where(w => w.Id == Id).FirstOrDefault();

            return client;
        }

        public List<Cliente> GetAllClients()
        {
            List<Cliente> clients = new List<Cliente>();

            try
            {
                clients = _context.Clientes.ToList();
            }catch(Exception ex)
            {
                throw ex;
            }

            return clients;
        }


        public Dictionary<string, string> Create(Cliente cliente)
        {
            Dictionary<string, string> retorno = new Dictionary<string, string>();

            try
            {
                _context.Clientes.Add(cliente);
                _context.SaveChanges();
            } catch(Exception ex)
            {
                retorno.Add("Erro ao tentar Salvar ", ex.ToString());
            }

            return retorno;
        }


        public Dictionary<string, string> Edit(Cliente cliente)
        {
            Dictionary<string, string> retorno = new Dictionary<string, string>();

            try
            {
                _context.Update(cliente);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                retorno.Add("Erro ao tentar Salvar ", ex.ToString());
            }

            return retorno;
        }

    }
}

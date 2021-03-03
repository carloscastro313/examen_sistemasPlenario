using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocios
{
    public class Negocio
    {
        private PersonasDB db;

        public Negocio()
        {
            try
            {
                this.db = new PersonasDB();
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos");
            }
        }

        public List<Persona> GetLista
        {
            get
            {
                try
                {
                    List<Persona> lista = new List<Persona>();

                    lista = this.db.Personas
                                    .Select(x => new Persona()
                                    {
                                        PersonaID = x.PersonaID,
                                        Nombre = x.Nombre,
                                        FechaNacimiento = x.FechaNacimiento,
                                        CreditoMaximo = x.CreditoMaximo
                                    })
                                    .ToList<Persona>();

                    return lista;
                }
                catch (Exception)
                {
                    throw new Exception("Error en la base de datos");
                }

            }
        }

        public List<TelefonoPersona> GetListaTelefono(int id)
        {

            try
            {
                List<TelefonoPersona> lista = new List<TelefonoPersona>();

                lista = this.db.Telefonos
                               .Where(x => x.PersonaID == id)
                               .Select(x => new TelefonoPersona()
                                {
                                    PersonaID = x.PersonaID,
                                    Telefono = x.Telefono,
                                    TelefonoID = x.TelefonoID
                                }).ToList<TelefonoPersona>();

                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos");
            }
        }

        public void AgregarPersona(Persona persona)
        {
            try
            {
                var p = new Personas()
                {
                    Nombre = persona.Nombre,
                    CreditoMaximo = persona.CreditoMaximo,
                    FechaNacimiento = persona.FechaNacimiento
                };

                this.db.Personas.Add(p);
                this.db.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool EliminarPersona(int id)
        {
            bool flag = false;
            try
            {
                var personaEliminar = this.db.Personas
                                          .Where(x => x.PersonaID == id).FirstOrDefault();
                if(personaEliminar != null)
                {
                    this.purgarTelefonos(personaEliminar.PersonaID);
                    this.db.Personas.Remove(personaEliminar);

                    this.db.SaveChanges();

                    flag = true;
                }
            } catch (Exception e)
            {
                throw e;
            }

            return flag;
        }
        private void purgarTelefonos(int idP)
        {
            try
            {
                var telefonoEliminar = this.db.Telefonos
                                               .Where(x => x.PersonaID == idP);
                if (telefonoEliminar.Count() > 0)
                {
                    foreach(Telefonos t in telefonoEliminar)
                    {
                        this.db.Telefonos.Remove(t);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool ModificarPersona(Persona persona)
        {
            bool flag = false;
            try
            {
                var personaModificar = this.db.Personas
                                               .Single(x => x.PersonaID == persona.PersonaID);
                if (personaModificar != null)
                {
                    personaModificar.Nombre = persona.Nombre;
                    personaModificar.CreditoMaximo = persona.CreditoMaximo;
                    personaModificar.FechaNacimiento = persona.FechaNacimiento;

                    this.db.SaveChanges();

                    flag = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return flag;
        }

        public List<Persona> GetPersonas_Nombre(string nombre)
        {
            try
            {
                List<Persona> lista = new List<Persona>();

                lista = this.db.Personas
                                .Where(x => x.Nombre.Contains(nombre))
                                .Select(x => new Persona()
                                {
                                    PersonaID = x.PersonaID,
                                    Nombre = x.Nombre,
                                    FechaNacimiento = x.FechaNacimiento,
                                    CreditoMaximo = x.CreditoMaximo
                                }).ToList<Persona>();

                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos");
            }
        }
        public void AgregarTelefono(TelefonoPersona telefono)
        {
            try
            {
                Personas p = this.db.Personas
                                    .Where(x => x.PersonaID == telefono.PersonaID)
                                    .FirstOrDefault();

                Telefonos t = new Telefonos()
                {
                    Telefono = telefono.Telefono,
                    PersonaID = telefono.PersonaID,
                    Personas = p
                };

                this.db.Telefonos.Add(t);
                this.db.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool EliminarTelefono(int id)
        {
            bool flag = false;
            try
            {
                var telefonoEliminar = this.db.Telefonos
                                                .Where(x => x.TelefonoID == id)
                                                .FirstOrDefault();
                if (telefonoEliminar != null)
                {
                    this.db.Telefonos.Remove(telefonoEliminar);

                    this.db.SaveChanges();

                    flag = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return flag;
        }

        public bool ModificarTelefono(TelefonoPersona telefono)
        {
            bool flag = false;
            try
            {
                var telefonoModificar = this.db.Telefonos
                                               .Single(x => x.TelefonoID == telefono.TelefonoID);
                if (telefonoModificar != null)
                {
                    telefonoModificar.Telefono = telefono.Telefono;

                    this.db.SaveChanges();

                    flag = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return flag;
        }

    }
}

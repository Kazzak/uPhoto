using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BuPhoto.Models;

namespace BuPhoto.Controllers
{
    public class SesionController : Controller
    {
        //
        // GET: /Sesion/

        public ActionResult LogON()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogOn(LogONModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (ValidateUser(model.UserName, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
                    if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                        && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Inicio");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "El nombre de usuario o la contraseña provistos son incorrectos.");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Inicio");
        }

        public ActionResult Register()
        {
            List<SelectListItem> pais = new List<SelectListItem>();
            pais.Add(new SelectListItem { Text = "AF", Value = "Afganistán" });
            pais.Add(new SelectListItem { Text = "AL", Value = "Albania" });
            pais.Add(new SelectListItem { Text = "DE", Value = "Alemania" });
            pais.Add(new SelectListItem { Text = "AD", Value = "Andorra" });
            pais.Add(new SelectListItem { Text = "AO", Value = "Angola" });
            pais.Add(new SelectListItem { Text = "AI", Value = "Anguilla" });
            pais.Add(new SelectListItem { Text = "AQ", Value = "Antártida" });
            pais.Add(new SelectListItem { Text = "AG", Value = "Antigua y Barbuda" });
            pais.Add(new SelectListItem { Text = "AN", Value = "Antillas Holandesas" });
            pais.Add(new SelectListItem { Text = "SA", Value = "Arabia Saudí" });
            pais.Add(new SelectListItem { Text = "DZ", Value = "Argelia" });
            pais.Add(new SelectListItem { Text = "AR", Value = "Argentina" });
            pais.Add(new SelectListItem { Text = "AM", Value = "Armenia" });
            pais.Add(new SelectListItem { Text = "AW", Value = "Aruba" });
            pais.Add(new SelectListItem { Text = "AU", Value = "Australia" });
            pais.Add(new SelectListItem { Text = "AT", Value = "Austria" });
            pais.Add(new SelectListItem { Text = "AZ", Value = "Azerbaiyán" });
            pais.Add(new SelectListItem { Text = "BS", Value = "Bahamas" });
            pais.Add(new SelectListItem { Text = "BH", Value = "Bahrein" });
            pais.Add(new SelectListItem { Text = "BD", Value = "Bangladesh" });
            pais.Add(new SelectListItem { Text = "BB", Value = "Barbados" });
            pais.Add(new SelectListItem { Text = "BE", Value = "Bélgica" });
            pais.Add(new SelectListItem { Text = "BZ", Value = "Belice" });
            pais.Add(new SelectListItem { Text = "BJ", Value = "Benin" });
            pais.Add(new SelectListItem { Text = "BM", Value = "Bermudas" });
            pais.Add(new SelectListItem { Text = "BY", Value = "Bielorrusia" });
            pais.Add(new SelectListItem { Text = "MM", Value = "Birmania" });
            pais.Add(new SelectListItem { Text = "BO", Value = "Bolivia" });
            pais.Add(new SelectListItem { Text = "BA", Value = "Bosnia y Herzegovina" });
            pais.Add(new SelectListItem { Text = "BW", Value = "Botswana" });
            pais.Add(new SelectListItem { Text = "BR", Value = "Brasil" });
            pais.Add(new SelectListItem { Text = "BN", Value = "Brunei" });
            pais.Add(new SelectListItem { Text = "BG", Value = "Bulgaria" });
            pais.Add(new SelectListItem { Text = "BF", Value = "Burkina Faso" });
            pais.Add(new SelectListItem { Text = "BI", Value = "Burundi" });
            pais.Add(new SelectListItem { Text = "BT", Value = "Bután" });
            pais.Add(new SelectListItem { Text = "CV", Value = "Cabo Verde" });
            pais.Add(new SelectListItem { Text = "KH", Value = "Camboya" });
            pais.Add(new SelectListItem { Text = "CM", Value = "Camerún" });
            pais.Add(new SelectListItem { Text = "CA", Value = "Canadá" });
            pais.Add(new SelectListItem { Text = "TD", Value = "Chad" });
            pais.Add(new SelectListItem { Text = "CL", Value = "Chile" });
            pais.Add(new SelectListItem { Text = "CN", Value = "China" });
            pais.Add(new SelectListItem { Text = "CY", Value = "Chipre" });
            pais.Add(new SelectListItem { Text = "VA", Value = "Ciudad del Vaticano (Santa Sede)" });
            pais.Add(new SelectListItem { Text = "CO", Value = "Colombia" });
            pais.Add(new SelectListItem { Text = "KM", Value = "Comores" });
            pais.Add(new SelectListItem { Text = "CG", Value = "Congo" });
            pais.Add(new SelectListItem { Text = "CD", Value = "Congo, República Democrática del" });
            pais.Add(new SelectListItem { Text = "KR", Value = "Corea" });
            pais.Add(new SelectListItem { Text = "KP", Value = "Corea del Norte" });
            pais.Add(new SelectListItem { Text = "CI", Value = "Costa de Marfíl" });
            pais.Add(new SelectListItem { Text = "CR", Value = "Costa Rica", Selected = true });
            pais.Add(new SelectListItem { Text = "HR", Value = "Croacia (Hrvatska)" });
            pais.Add(new SelectListItem { Text = "CU", Value = "Cuba" });
            pais.Add(new SelectListItem { Text = "DK", Value = "Dinamarca" });
            pais.Add(new SelectListItem { Text = "DJ", Value = "Djibouti" });
            pais.Add(new SelectListItem { Text = "DM", Value = "Dominica" });
            pais.Add(new SelectListItem { Text = "EC", Value = "Ecuador" });
            pais.Add(new SelectListItem { Text = "EG", Value = "Egipto" });
            pais.Add(new SelectListItem { Text = "SV", Value = "El Salvador" });
            pais.Add(new SelectListItem { Text = "AE", Value = "Emiratos Árabes Unidos" });
            pais.Add(new SelectListItem { Text = "ER", Value = "Eritrea" });
            pais.Add(new SelectListItem { Text = "SI", Value = "Eslovenia" });
            pais.Add(new SelectListItem { Text = "ES", Value = "España" });
            pais.Add(new SelectListItem { Text = "US", Value = "Estados Unidos" });
            pais.Add(new SelectListItem { Text = "EE", Value = "Estonia" });
            pais.Add(new SelectListItem { Text = "ET", Value = "Etiopía" });
            pais.Add(new SelectListItem { Text = "FJ", Value = "Fiji" });
            pais.Add(new SelectListItem { Text = "PH", Value = "Filipinas" });
            pais.Add(new SelectListItem { Text = "FI", Value = "Finlandia" });
            pais.Add(new SelectListItem { Text = "FR", Value = "Francia" });
            pais.Add(new SelectListItem { Text = "GA", Value = "Gabón" });
            pais.Add(new SelectListItem { Text = "GM", Value = "Gambia" });
            pais.Add(new SelectListItem { Text = "GE", Value = "Georgia" });
            pais.Add(new SelectListItem { Text = "GH", Value = "Ghana" });
            pais.Add(new SelectListItem { Text = "GI", Value = "Gibraltar" });
            pais.Add(new SelectListItem { Text = "GD", Value = "Granada" });
            pais.Add(new SelectListItem { Text = "GR", Value = "Grecia" });
            pais.Add(new SelectListItem { Text = "GL", Value = "Groenlandia" });
            pais.Add(new SelectListItem { Text = "GP", Value = "Guadalupe" });
            pais.Add(new SelectListItem { Text = "GU", Value = "Guam" });
            pais.Add(new SelectListItem { Text = "GT", Value = "Guatemala" });
            pais.Add(new SelectListItem { Text = "GY", Value = "Guayana" });
            pais.Add(new SelectListItem { Text = "GF", Value = "Guayana Francesa" });
            pais.Add(new SelectListItem { Text = "GN", Value = "Guinea" });
            pais.Add(new SelectListItem { Text = "GQ", Value = "Guinea Ecuatorial" });
            pais.Add(new SelectListItem { Text = "GW", Value = "Guinea-Bissau" });
            pais.Add(new SelectListItem { Text = "HT", Value = "Haití" });
            pais.Add(new SelectListItem { Text = "HN", Value = "Honduras" });
            pais.Add(new SelectListItem { Text = "HU", Value = "Hungría" });
            pais.Add(new SelectListItem { Text = "IN", Value = "India" });
            pais.Add(new SelectListItem { Text = "ID", Value = "Indonesia" });
            pais.Add(new SelectListItem { Text = "IQ", Value = "Irak" });
            pais.Add(new SelectListItem { Text = "IR", Value = "Irán" });
            pais.Add(new SelectListItem { Text = "IE", Value = "Irlanda" });
            pais.Add(new SelectListItem { Text = "BV", Value = "Isla Bouvet" });
            pais.Add(new SelectListItem { Text = "CX", Value = "Isla de Christmas" });
            pais.Add(new SelectListItem { Text = "IS", Value = "Islandia" });
            pais.Add(new SelectListItem { Text = "KY", Value = "Islas Caimán" });
            pais.Add(new SelectListItem { Text = "CK", Value = "Islas Cook" });
            pais.Add(new SelectListItem { Text = "CC", Value = "Islas de Cocos o Keeling" });
            pais.Add(new SelectListItem { Text = "FO", Value = "Islas Faroe" });
            pais.Add(new SelectListItem { Text = "HM", Value = "Islas Heard y McDonald" });
            pais.Add(new SelectListItem { Text = "FK", Value = "Islas Malvinas" });
            pais.Add(new SelectListItem { Text = "MP", Value = "Islas Marianas del Norte" });
            pais.Add(new SelectListItem { Text = "MH", Value = "Islas Marshall" });
            pais.Add(new SelectListItem { Text = "UM", Value = "Islas menores de Estados Unidos" });
            pais.Add(new SelectListItem { Text = "PW", Value = "Islas Palau" });
            pais.Add(new SelectListItem { Text = "SB", Value = "Islas Salomón" });
            pais.Add(new SelectListItem { Text = "SJ", Value = "Islas Svalbard y Jan Mayen" });
            pais.Add(new SelectListItem { Text = "TK", Value = "Islas Tokelau" });
            pais.Add(new SelectListItem { Text = "TC", Value = "Islas Turks y Caicos" });
            pais.Add(new SelectListItem { Text = "VI", Value = "Islas Vírgenes (EEUU)" });
            pais.Add(new SelectListItem { Text = "VG", Value = "Islas Vírgenes (Reino Unido)" });
            pais.Add(new SelectListItem { Text = "WF", Value = "Islas Wallis y Futuna" });
            pais.Add(new SelectListItem { Text = "IL", Value = "Israel" });
            pais.Add(new SelectListItem { Text = "IT", Value = "Italia" });
            pais.Add(new SelectListItem { Text = "JM", Value = "Jamaica" });
            pais.Add(new SelectListItem { Text = "JP", Value = "Japón" });
            pais.Add(new SelectListItem { Text = "JO", Value = "Jordania" });
            pais.Add(new SelectListItem { Text = "KZ", Value = "Kazajistán" });
            pais.Add(new SelectListItem { Text = "KE", Value = "Kenia" });
            pais.Add(new SelectListItem { Text = "KG", Value = "Kirguizistán" });
            pais.Add(new SelectListItem { Text = "KI", Value = "Kiribati" });
            pais.Add(new SelectListItem { Text = "KW", Value = "Kuwait" });
            pais.Add(new SelectListItem { Text = "LA", Value = "Laos" });
            pais.Add(new SelectListItem { Text = "LS", Value = "Lesotho" });
            pais.Add(new SelectListItem { Text = "LV", Value = "Letonia" });
            pais.Add(new SelectListItem { Text = "LB", Value = "Líbano" });
            pais.Add(new SelectListItem { Text = "LR", Value = "Liberia" });
            pais.Add(new SelectListItem { Text = "LY", Value = "Libia" });
            pais.Add(new SelectListItem { Text = "LI", Value = "Liechtenstein" });
            pais.Add(new SelectListItem { Text = "LT", Value = "Lituania" });
            pais.Add(new SelectListItem { Text = "LU", Value = "Luxemburgo" });
            pais.Add(new SelectListItem { Text = "MK", Value = "Macedonia, Ex-República Yugoslava de" });
            pais.Add(new SelectListItem { Text = "MG", Value = "Madagascar" });
            pais.Add(new SelectListItem { Text = "MY", Value = "Malasia" });
            pais.Add(new SelectListItem { Text = "MW", Value = "Malawi" });
            pais.Add(new SelectListItem { Text = "MV", Value = "Maldivas" });
            pais.Add(new SelectListItem { Text = "ML", Value = "Malí" });
            pais.Add(new SelectListItem { Text = "MT", Value = "Malta" });
            pais.Add(new SelectListItem { Text = "MA", Value = "Marruecos" });
            pais.Add(new SelectListItem { Text = "MQ", Value = "Martinica" });
            pais.Add(new SelectListItem { Text = "MU", Value = "Mauricio" });
            pais.Add(new SelectListItem { Text = "MR", Value = "Mauritania" });
            pais.Add(new SelectListItem { Text = "YT", Value = "Mayotte" });
            pais.Add(new SelectListItem { Text = "MX", Value = "México" });
            pais.Add(new SelectListItem { Text = "FM", Value = "Micronesia" });
            pais.Add(new SelectListItem { Text = "MD", Value = "Moldavia" });
            pais.Add(new SelectListItem { Text = "MC", Value = "Mónaco" });
            pais.Add(new SelectListItem { Text = "MN", Value = "Mongolia" });
            pais.Add(new SelectListItem { Text = "MS", Value = "Montserrat" });
            pais.Add(new SelectListItem { Text = "MZ", Value = "Mozambique" });
            pais.Add(new SelectListItem { Text = "NA", Value = "Namibia" });
            pais.Add(new SelectListItem { Text = "NR", Value = "Nauru" });
            pais.Add(new SelectListItem { Text = "NP", Value = "Nepal" });
            pais.Add(new SelectListItem { Text = "NI", Value = "Nicaragua" });
            pais.Add(new SelectListItem { Text = "NE", Value = "Níger" });
            pais.Add(new SelectListItem { Text = "NG", Value = "Nigeria" });
            pais.Add(new SelectListItem { Text = "NU", Value = "Niue" });
            pais.Add(new SelectListItem { Text = "NF", Value = "Norfolk" });
            pais.Add(new SelectListItem { Text = "NO", Value = "Noruega" });
            pais.Add(new SelectListItem { Text = "NC", Value = "Nueva Caledonia" });
            pais.Add(new SelectListItem { Text = "NZ", Value = "Nueva Zelanda" });
            pais.Add(new SelectListItem { Text = "OM", Value = "Omán" });
            pais.Add(new SelectListItem { Text = "NL", Value = "Países Bajos" });
            pais.Add(new SelectListItem { Text = "PA", Value = "Panamá" });
            pais.Add(new SelectListItem { Text = "PG", Value = "Papúa Nueva Guinea" });
            pais.Add(new SelectListItem { Text = "PK", Value = "Paquistán" });
            pais.Add(new SelectListItem { Text = "PY", Value = "Paraguay" });
            pais.Add(new SelectListItem { Text = "PE", Value = "Perú" });
            pais.Add(new SelectListItem { Text = "PN", Value = "Pitcairn" });
            pais.Add(new SelectListItem { Text = "PF", Value = "Polinesia Francesa" });
            pais.Add(new SelectListItem { Text = "PL", Value = "Polonia" });
            pais.Add(new SelectListItem { Text = "PT", Value = "Portugal" });
            pais.Add(new SelectListItem { Text = "PR", Value = "Puerto Rico" });
            pais.Add(new SelectListItem { Text = "QA", Value = "Qatar" });
            pais.Add(new SelectListItem { Text = "UK", Value = "Reino Unido" });
            pais.Add(new SelectListItem { Text = "CF", Value = "República Centroafricana" });
            pais.Add(new SelectListItem { Text = "CZ", Value = "República Checa" });
            pais.Add(new SelectListItem { Text = "ZA", Value = "República de Sudáfrica" });
            pais.Add(new SelectListItem { Text = "DO", Value = "República Dominicana" });
            pais.Add(new SelectListItem { Text = "SK", Value = "República Eslovaca" });
            pais.Add(new SelectListItem { Text = "RE", Value = "Reunión" });
            pais.Add(new SelectListItem { Text = "RW", Value = "Ruanda" });
            pais.Add(new SelectListItem { Text = "RO", Value = "Rumania" });
            pais.Add(new SelectListItem { Text = "RU", Value = "Rusia" });
            pais.Add(new SelectListItem { Text = "EH", Value = "Sahara Occidental" });
            pais.Add(new SelectListItem { Text = "KN", Value = "Saint Kitts y Nevis" });
            pais.Add(new SelectListItem { Text = "WS", Value = "Samoa" });
            pais.Add(new SelectListItem { Text = "AS", Value = "Samoa Americana" });
            pais.Add(new SelectListItem { Text = "SM", Value = "San Marino" });
            pais.Add(new SelectListItem { Text = "VC", Value = "San Vicente y Granadinas" });
            pais.Add(new SelectListItem { Text = "SH", Value = "Santa Helena" });
            pais.Add(new SelectListItem { Text = "LC", Value = "Santa Lucía" });
            pais.Add(new SelectListItem { Text = "ST", Value = "Santo Tomé y Príncipe" });
            pais.Add(new SelectListItem { Text = "SN", Value = "Senegal" });
            pais.Add(new SelectListItem { Text = "SC", Value = "Seychelles" });
            pais.Add(new SelectListItem { Text = "SL", Value = "Sierra Leona" });
            pais.Add(new SelectListItem { Text = "SG", Value = "Singapur" });
            pais.Add(new SelectListItem { Text = "SY", Value = "Siria" });
            pais.Add(new SelectListItem { Text = "SO", Value = "Somalia" });
            pais.Add(new SelectListItem { Text = "LK", Value = "Sri Lanka" });
            pais.Add(new SelectListItem { Text = "PM", Value = "St Pierre y Miquelon" });
            pais.Add(new SelectListItem { Text = "SZ", Value = "Suazilandia" });
            pais.Add(new SelectListItem { Text = "SD", Value = "Sudán" });
            pais.Add(new SelectListItem { Text = "SE", Value = "Suecia" });
            pais.Add(new SelectListItem { Text = "CH", Value = "Suiza" });
            pais.Add(new SelectListItem { Text = "SR", Value = "Surinam" });
            pais.Add(new SelectListItem { Text = "TH", Value = "Tailandia" });
            pais.Add(new SelectListItem { Text = "TW", Value = "Taiwán" });
            pais.Add(new SelectListItem { Text = "TZ", Value = "Tanzania" });
            pais.Add(new SelectListItem { Text = "TJ", Value = "Tayikistán" });
            pais.Add(new SelectListItem { Text = "TF", Value = "Territorios franceses del Sur" });
            pais.Add(new SelectListItem { Text = "TP", Value = "Timor Oriental" });
            pais.Add(new SelectListItem { Text = "TG", Value = "Togo" });
            pais.Add(new SelectListItem { Text = "TO", Value = "Tonga" });
            pais.Add(new SelectListItem { Text = "TT", Value = "Trinidad y Tobago" });
            pais.Add(new SelectListItem { Text = "TN", Value = "Túnez" });
            pais.Add(new SelectListItem { Text = "TM", Value = "Turkmenistán" });
            pais.Add(new SelectListItem { Text = "TR", Value = "Turquía" });
            pais.Add(new SelectListItem { Text = "TV", Value = "Tuvalu" });
            pais.Add(new SelectListItem { Text = "UA", Value = "Ucrania" });
            pais.Add(new SelectListItem { Text = "UG", Value = "Uganda" });
            pais.Add(new SelectListItem { Text = "UY", Value = "Uruguay" });
            pais.Add(new SelectListItem { Text = "UZ", Value = "Uzbekistán" });
            pais.Add(new SelectListItem { Text = "VU", Value = "Vanuatu" });
            pais.Add(new SelectListItem { Text = "VE", Value = "Venezuela" });
            pais.Add(new SelectListItem { Text = "VN", Value = "Vietnam" });
            pais.Add(new SelectListItem { Text = "YE", Value = "Yemen" });
            pais.Add(new SelectListItem { Text = "YU", Value = "Yugoslavia" });
            pais.Add(new SelectListItem { Text = "ZM", Value = "Zambia" });
            pais.Add(new SelectListItem { Text = "ZW", Value = "Zimbabue" });
            ViewBag.PaisOrigen = new SelectList(pais, "Text", "Value");

            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var bd = new uPhotoEntities();
                    sesion sesion = new sesion
                    {
                        idsesion = model.UserName,
                        password = model.Password,
                        fecharegistro = DateTime.Now,
                    };
                    bd.sesion.Add(sesion);
                    

                    usuario user = new usuario
                    {
                        idsesion = model.UserName,
                        nombre = model.Name,
                        apellido = model.LastName,
                        fecharegistro = DateTime.Now,
                        email = model.Email,
                        nacionalidad = model.PaisOrigen.ToString()
                    };

                    bd.usuario.Add(user);
                    // Attempt to register the user
                    //MembershipCreateStatus createStatus;
                    //Membership.CreateUser(model.UserName, model.Password, model.Email, null, null, true, null, out createStatus);

                    if (Save(bd) == true)
                    {
                        FormsAuthentication.SetAuthCookie(model.UserName, false /* createPersistentCookie */);
                        return RedirectToAction("Index", "Inicio");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Error al registrar al usuario, verificar los datos ingresados.");
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc);
                }
            }

            // If we got this far, something failed, redisplay form
            return Register();
            //return View(model);
        }

        public static bool ValidateUser(string user, string password)
        {
            var bd = new uPhotoEntities();
            var usuario = bd.sesion.FirstOrDefault(x => x.idsesion.Equals(user) && x.password.Equals(password));

            if (usuario != null)
            {
                //Si el nombre de usuario y la contraseña coinciden se devuelve true
                return true;
            }
            return false;
        }

        //Guarda los cambios realizados en la base de datos
        public static bool Save(uPhotoEntities db)
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
    
    }
}

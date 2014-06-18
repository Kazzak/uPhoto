using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using uPhoto.Models;

namespace uPhoto.Controllers
{
    public class AccountController : Controller
    {

        //
        // GET: /Account/LogOn

        public ActionResult LogOn()
        {
            return View();
        }

        //
        // POST: /Account/LogOn

        [HttpPost]
        public ActionResult LogOn(LogOnModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (LoginController.ValidateUser(model.UserName, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
                    if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                        && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "The user name or password provided is incorrect.");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/LogOff

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Home");
        }

        //
        // GET: /Account/Register

        public ActionResult Register()
        {
            List<SelectListItem> pais = new List<SelectListItem>();
            pais.Add(new SelectListItem { Text = "AF", Value="Afganistán" });
            pais.Add(new SelectListItem { Text = "AL",Value="Albania" });
            pais.Add(new SelectListItem { Text = "DE",Value="Alemania" });
            pais.Add(new SelectListItem { Text = "AD",Value="Andorra" });
            pais.Add(new SelectListItem { Text = "AO",Value="Angola" });
            pais.Add(new SelectListItem { Text = "AI",Value="Anguilla" });
            pais.Add(new SelectListItem { Text = "AQ",Value="Antártida" });
            pais.Add(new SelectListItem { Text = "AG",Value="Antigua y Barbuda" });
            pais.Add(new SelectListItem { Text = "AN",Value="Antillas Holandesas" });
            pais.Add(new SelectListItem { Text = "SA",Value="Arabia Saudí" });
            pais.Add(new SelectListItem { Text = "DZ",Value="Argelia" });
            pais.Add(new SelectListItem { Text = "AR",Value="Argentina" });
            pais.Add(new SelectListItem { Text = "AM",Value="Armenia" });
            pais.Add(new SelectListItem { Text = "AW",Value="Aruba" });
            pais.Add(new SelectListItem { Text = "AU",Value="Australia" });
            pais.Add(new SelectListItem { Text = "AT",Value="Austria" });
            pais.Add(new SelectListItem { Text = "AZ",Value="Azerbaiyán" });
            pais.Add(new SelectListItem { Text = "BS",Value="Bahamas" });
            pais.Add(new SelectListItem { Text = "BH",Value="Bahrein" });
            pais.Add(new SelectListItem { Text = "BD",Value="Bangladesh" });
            pais.Add(new SelectListItem { Text = "BB",Value="Barbados" });
            pais.Add(new SelectListItem { Text = "BE",Value="Bélgica" });
            pais.Add(new SelectListItem { Text = "BZ",Value="Belice" });
            pais.Add(new SelectListItem { Text = "BJ",Value="Benin" });
            pais.Add(new SelectListItem { Text = "BM",Value="Bermudas" });
            pais.Add(new SelectListItem { Text = "BY",Value="Bielorrusia" });
            pais.Add(new SelectListItem { Text = "MM",Value="Birmania" });
            pais.Add(new SelectListItem { Text = "BO",Value="Bolivia" });
            pais.Add(new SelectListItem { Text = "BA",Value="Bosnia y Herzegovina" });
            pais.Add(new SelectListItem { Text = "BW",Value="Botswana" });
            pais.Add(new SelectListItem { Text = "BR",Value="Brasil" });
            pais.Add(new SelectListItem { Text = "BN",Value="Brunei" });
            pais.Add(new SelectListItem { Text = "BG",Value="Bulgaria" });
            pais.Add(new SelectListItem { Text = "BF",Value="Burkina Faso" });
            pais.Add(new SelectListItem { Text = "BI",Value="Burundi" });
            pais.Add(new SelectListItem { Text = "BT",Value="Bután" });
            pais.Add(new SelectListItem { Text = "CV",Value="Cabo Verde" });
            pais.Add(new SelectListItem { Text = "KH",Value="Camboya" });
            pais.Add(new SelectListItem { Text = "CM",Value="Camerún" });
            pais.Add(new SelectListItem { Text = "CA",Value="Canadá" });
            pais.Add(new SelectListItem { Text = "TD",Value="Chad" });
            pais.Add(new SelectListItem { Text = "CL",Value="Chile" });
            pais.Add(new SelectListItem { Text = "CN",Value="China" });
            pais.Add(new SelectListItem { Text = "CY",Value="Chipre" });
            pais.Add(new SelectListItem { Text = "VA",Value="Ciudad del Vaticano (Santa Sede)" });
            pais.Add(new SelectListItem { Text = "CO",Value="Colombia" });
            pais.Add(new SelectListItem { Text = "KM",Value="Comores" });
            pais.Add(new SelectListItem { Text = "CG",Value="Congo" });
            pais.Add(new SelectListItem { Text = "CD",Value="Congo, República Democrática del" });
            pais.Add(new SelectListItem { Text = "KR",Value="Corea" });
            pais.Add(new SelectListItem { Text = "KP",Value="Corea del Norte" });
            pais.Add(new SelectListItem { Text = "CI",Value="Costa de Marfíl" });
            pais.Add(new SelectListItem { Text = "CR",Value="Costa Rica", Selected=true });
            pais.Add(new SelectListItem { Text = "HR",Value="Croacia (Hrvatska)" });
            pais.Add(new SelectListItem { Text = "CU",Value="Cuba" });
            pais.Add(new SelectListItem { Text = "DK",Value="Dinamarca" });
            pais.Add(new SelectListItem { Text = "DJ",Value="Djibouti" });
            pais.Add(new SelectListItem { Text = "DM",Value="Dominica" });
            pais.Add(new SelectListItem { Text = "EC",Value="Ecuador" });
            pais.Add(new SelectListItem { Text = "EG",Value="Egipto" });
            pais.Add(new SelectListItem { Text = "SV",Value="El Salvador" });
            pais.Add(new SelectListItem { Text = "AE",Value="Emiratos Árabes Unidos" });
            pais.Add(new SelectListItem { Text = "ER",Value="Eritrea" });
            pais.Add(new SelectListItem { Text = "SI",Value="Eslovenia" });
            pais.Add(new SelectListItem { Text = "ES",Value="España" });
            pais.Add(new SelectListItem { Text = "US",Value="Estados Unidos" });
            pais.Add(new SelectListItem { Text = "EE",Value="Estonia" });
            pais.Add(new SelectListItem { Text = "ET",Value="Etiopía" });
            pais.Add(new SelectListItem { Text = "FJ",Value="Fiji" });
            pais.Add(new SelectListItem { Text = "PH",Value="Filipinas" });
            pais.Add(new SelectListItem { Text = "FI",Value="Finlandia" });
            pais.Add(new SelectListItem { Text = "FR",Value="Francia" });
            pais.Add(new SelectListItem { Text = "GA",Value="Gabón" });
            pais.Add(new SelectListItem { Text = "GM",Value="Gambia" });
            pais.Add(new SelectListItem { Text = "GE",Value="Georgia" });
            pais.Add(new SelectListItem { Text = "GH",Value="Ghana" });
            pais.Add(new SelectListItem { Text = "GI",Value="Gibraltar" });
            pais.Add(new SelectListItem { Text = "GD",Value="Granada" });
            pais.Add(new SelectListItem { Text = "GR",Value="Grecia" });
            pais.Add(new SelectListItem { Text = "GL",Value="Groenlandia" });
            pais.Add(new SelectListItem { Text = "GP",Value="Guadalupe" });
            pais.Add(new SelectListItem { Text = "GU",Value="Guam" });
            pais.Add(new SelectListItem { Text = "GT",Value="Guatemala" });
            pais.Add(new SelectListItem { Text = "GY",Value="Guayana" });
            pais.Add(new SelectListItem { Text = "GF",Value="Guayana Francesa" });
            pais.Add(new SelectListItem { Text = "GN",Value="Guinea" });
            pais.Add(new SelectListItem { Text = "GQ",Value="Guinea Ecuatorial" });
            pais.Add(new SelectListItem { Text = "GW",Value="Guinea-Bissau" });
            pais.Add(new SelectListItem { Text = "HT",Value="Haití" });
            pais.Add(new SelectListItem { Text = "HN",Value="Honduras" });
            pais.Add(new SelectListItem { Text = "HU",Value="Hungría" });
            pais.Add(new SelectListItem { Text = "IN",Value="India" });
            pais.Add(new SelectListItem { Text = "ID",Value="Indonesia" });
            pais.Add(new SelectListItem { Text = "IQ",Value="Irak" });
            pais.Add(new SelectListItem { Text = "IR",Value="Irán" });
            pais.Add(new SelectListItem { Text = "IE",Value="Irlanda" });
            pais.Add(new SelectListItem { Text = "BV",Value="Isla Bouvet" });
            pais.Add(new SelectListItem { Text = "CX",Value="Isla de Christmas" });
            pais.Add(new SelectListItem { Text = "IS",Value="Islandia" });
            pais.Add(new SelectListItem { Text = "KY",Value="Islas Caimán" });
            pais.Add(new SelectListItem { Text = "CK",Value="Islas Cook" });
            pais.Add(new SelectListItem { Text = "CC",Value="Islas de Cocos o Keeling" });
            pais.Add(new SelectListItem { Text = "FO",Value="Islas Faroe" });
            pais.Add(new SelectListItem { Text = "HM",Value="Islas Heard y McDonald" });
            pais.Add(new SelectListItem { Text = "FK",Value="Islas Malvinas" });
            pais.Add(new SelectListItem { Text = "MP",Value="Islas Marianas del Norte" });
            pais.Add(new SelectListItem { Text = "MH",Value="Islas Marshall" });
            pais.Add(new SelectListItem { Text = "UM",Value="Islas menores de Estados Unidos" });
            pais.Add(new SelectListItem { Text = "PW",Value="Islas Palau" });
            pais.Add(new SelectListItem { Text = "SB",Value="Islas Salomón" });
            pais.Add(new SelectListItem { Text = "SJ",Value="Islas Svalbard y Jan Mayen" });
            pais.Add(new SelectListItem { Text = "TK",Value="Islas Tokelau" });
            pais.Add(new SelectListItem { Text = "TC",Value="Islas Turks y Caicos" });
            pais.Add(new SelectListItem { Text = "VI",Value="Islas Vírgenes (EEUU)" });
            pais.Add(new SelectListItem { Text = "VG",Value="Islas Vírgenes (Reino Unido)" });
            pais.Add(new SelectListItem { Text = "WF",Value="Islas Wallis y Futuna" });
            pais.Add(new SelectListItem { Text = "IL",Value="Israel" });
            pais.Add(new SelectListItem { Text = "IT",Value="Italia" });
            pais.Add(new SelectListItem { Text = "JM",Value="Jamaica" });
            pais.Add(new SelectListItem { Text = "JP",Value="Japón" });
            pais.Add(new SelectListItem { Text = "JO",Value="Jordania" });
            pais.Add(new SelectListItem { Text = "KZ",Value="Kazajistán" });
            pais.Add(new SelectListItem { Text = "KE",Value="Kenia" });
            pais.Add(new SelectListItem { Text = "KG",Value="Kirguizistán" });
            pais.Add(new SelectListItem { Text = "KI",Value="Kiribati" });
            pais.Add(new SelectListItem { Text = "KW",Value="Kuwait" });
            pais.Add(new SelectListItem { Text = "LA",Value="Laos" });
            pais.Add(new SelectListItem { Text = "LS",Value="Lesotho" });
            pais.Add(new SelectListItem { Text = "LV",Value="Letonia" });
            pais.Add(new SelectListItem { Text = "LB",Value="Líbano" });
            pais.Add(new SelectListItem { Text = "LR",Value="Liberia" });
            pais.Add(new SelectListItem { Text = "LY",Value="Libia" });
            pais.Add(new SelectListItem { Text = "LI",Value="Liechtenstein" });
            pais.Add(new SelectListItem { Text = "LT",Value="Lituania" });
            pais.Add(new SelectListItem { Text = "LU",Value="Luxemburgo" });
            pais.Add(new SelectListItem { Text = "MK",Value="Macedonia, Ex-República Yugoslava de" });
            pais.Add(new SelectListItem { Text = "MG",Value="Madagascar" });
            pais.Add(new SelectListItem { Text = "MY",Value="Malasia" });
            pais.Add(new SelectListItem { Text = "MW",Value="Malawi" });
            pais.Add(new SelectListItem { Text = "MV",Value="Maldivas" });
            pais.Add(new SelectListItem { Text = "ML",Value="Malí" });
            pais.Add(new SelectListItem { Text = "MT",Value="Malta" });
            pais.Add(new SelectListItem { Text = "MA",Value="Marruecos" });
            pais.Add(new SelectListItem { Text = "MQ",Value="Martinica" });
            pais.Add(new SelectListItem { Text = "MU",Value="Mauricio" });
            pais.Add(new SelectListItem { Text = "MR",Value="Mauritania" });
            pais.Add(new SelectListItem { Text = "YT",Value="Mayotte" });
            pais.Add(new SelectListItem { Text = "MX",Value="México" });
            pais.Add(new SelectListItem { Text = "FM",Value="Micronesia" });
            pais.Add(new SelectListItem { Text = "MD",Value="Moldavia" });
            pais.Add(new SelectListItem { Text = "MC",Value="Mónaco" });
            pais.Add(new SelectListItem { Text = "MN",Value="Mongolia" });
            pais.Add(new SelectListItem { Text = "MS",Value="Montserrat" });
            pais.Add(new SelectListItem { Text = "MZ",Value="Mozambique" });
            pais.Add(new SelectListItem { Text = "NA",Value="Namibia" });
            pais.Add(new SelectListItem { Text = "NR",Value="Nauru" });
            pais.Add(new SelectListItem { Text = "NP",Value="Nepal" });
            pais.Add(new SelectListItem { Text = "NI",Value="Nicaragua" });
            pais.Add(new SelectListItem { Text = "NE",Value="Níger" });
            pais.Add(new SelectListItem { Text = "NG",Value="Nigeria" });
            pais.Add(new SelectListItem { Text = "NU",Value="Niue" });
            pais.Add(new SelectListItem { Text = "NF",Value="Norfolk" });
            pais.Add(new SelectListItem { Text = "NO",Value="Noruega" });
            pais.Add(new SelectListItem { Text = "NC",Value="Nueva Caledonia" });
            pais.Add(new SelectListItem { Text = "NZ",Value="Nueva Zelanda" });
            pais.Add(new SelectListItem { Text = "OM",Value="Omán" });
            pais.Add(new SelectListItem { Text = "NL",Value="Países Bajos" });
            pais.Add(new SelectListItem { Text = "PA",Value="Panamá" });
            pais.Add(new SelectListItem { Text = "PG",Value="Papúa Nueva Guinea" });
            pais.Add(new SelectListItem { Text = "PK",Value="Paquistán" });
            pais.Add(new SelectListItem { Text = "PY",Value="Paraguay" });
            pais.Add(new SelectListItem { Text = "PE",Value="Perú" });
            pais.Add(new SelectListItem { Text = "PN",Value="Pitcairn" });
            pais.Add(new SelectListItem { Text = "PF",Value="Polinesia Francesa" });
            pais.Add(new SelectListItem { Text = "PL",Value="Polonia" });
            pais.Add(new SelectListItem { Text = "PT",Value="Portugal" });
            pais.Add(new SelectListItem { Text = "PR",Value="Puerto Rico" });
            pais.Add(new SelectListItem { Text = "QA",Value="Qatar" });
            pais.Add(new SelectListItem { Text = "UK",Value="Reino Unido" });
            pais.Add(new SelectListItem { Text = "CF",Value="República Centroafricana" });
            pais.Add(new SelectListItem { Text = "CZ",Value="República Checa" });
            pais.Add(new SelectListItem { Text = "ZA",Value="República de Sudáfrica" });
            pais.Add(new SelectListItem { Text = "DO",Value="República Dominicana" });
            pais.Add(new SelectListItem { Text = "SK",Value="República Eslovaca" });
            pais.Add(new SelectListItem { Text = "RE",Value="Reunión" });
            pais.Add(new SelectListItem { Text = "RW",Value="Ruanda" });
            pais.Add(new SelectListItem { Text = "RO",Value="Rumania" });
            pais.Add(new SelectListItem { Text = "RU",Value="Rusia" });
            pais.Add(new SelectListItem { Text = "EH",Value="Sahara Occidental" });
            pais.Add(new SelectListItem { Text = "KN",Value="Saint Kitts y Nevis" });
            pais.Add(new SelectListItem { Text = "WS",Value="Samoa" });
            pais.Add(new SelectListItem { Text = "AS",Value="Samoa Americana" });
            pais.Add(new SelectListItem { Text = "SM",Value="San Marino" });
            pais.Add(new SelectListItem { Text = "VC",Value="San Vicente y Granadinas" });
            pais.Add(new SelectListItem { Text = "SH",Value="Santa Helena" });
            pais.Add(new SelectListItem { Text = "LC",Value="Santa Lucía" });
            pais.Add(new SelectListItem { Text = "ST",Value="Santo Tomé y Príncipe" });
            pais.Add(new SelectListItem { Text = "SN",Value="Senegal" });
            pais.Add(new SelectListItem { Text = "SC",Value="Seychelles" });
            pais.Add(new SelectListItem { Text = "SL",Value="Sierra Leona" });
            pais.Add(new SelectListItem { Text = "SG",Value="Singapur" });
            pais.Add(new SelectListItem { Text = "SY",Value="Siria" });
            pais.Add(new SelectListItem { Text = "SO",Value="Somalia" });
            pais.Add(new SelectListItem { Text = "LK",Value="Sri Lanka" });
            pais.Add(new SelectListItem { Text = "PM",Value="St Pierre y Miquelon" });
            pais.Add(new SelectListItem { Text = "SZ",Value="Suazilandia" });
            pais.Add(new SelectListItem { Text = "SD",Value="Sudán" });
            pais.Add(new SelectListItem { Text = "SE",Value="Suecia" });
            pais.Add(new SelectListItem { Text = "CH",Value="Suiza" });
            pais.Add(new SelectListItem { Text = "SR",Value="Surinam" });
            pais.Add(new SelectListItem { Text = "TH",Value="Tailandia" });
            pais.Add(new SelectListItem { Text = "TW",Value="Taiwán" });
            pais.Add(new SelectListItem { Text = "TZ",Value="Tanzania" });
            pais.Add(new SelectListItem { Text = "TJ",Value="Tayikistán" });
            pais.Add(new SelectListItem { Text = "TF",Value="Territorios franceses del Sur" });
            pais.Add(new SelectListItem { Text = "TP",Value="Timor Oriental" });
            pais.Add(new SelectListItem { Text = "TG",Value="Togo" });
            pais.Add(new SelectListItem { Text = "TO",Value="Tonga" });
            pais.Add(new SelectListItem { Text = "TT",Value="Trinidad y Tobago" });
            pais.Add(new SelectListItem { Text = "TN",Value="Túnez" });
            pais.Add(new SelectListItem { Text = "TM",Value="Turkmenistán" });
            pais.Add(new SelectListItem { Text = "TR",Value="Turquía" });
            pais.Add(new SelectListItem { Text = "TV",Value="Tuvalu" });
            pais.Add(new SelectListItem { Text = "UA",Value="Ucrania" });
            pais.Add(new SelectListItem { Text = "UG",Value="Uganda" });
            pais.Add(new SelectListItem { Text = "UY",Value="Uruguay" });
            pais.Add(new SelectListItem { Text = "UZ",Value="Uzbekistán" });
            pais.Add(new SelectListItem { Text = "VU",Value="Vanuatu" });
            pais.Add(new SelectListItem { Text = "VE",Value="Venezuela" });
            pais.Add(new SelectListItem { Text = "VN",Value="Vietnam" });
            pais.Add(new SelectListItem { Text = "YE",Value="Yemen" });
            pais.Add(new SelectListItem { Text = "YU",Value="Yugoslavia" });
            pais.Add(new SelectListItem { Text = "ZM",Value="Zambia" });
            pais.Add(new SelectListItem { Text = "ZW",Value="Zimbabue" });
            ViewBag.PaisOrigen = new SelectList(pais, "Text", "Value");

            return View();
        }

        //
        // POST: /Account/Register

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
                        ultimoingreso = DateTime.Now
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

                    if (UserServices.Save(bd) == true)
                    {
                        FormsAuthentication.SetAuthCookie(model.UserName, false /* createPersistentCookie */);
                        return RedirectToAction("Index", "Home");
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

        //
        // GET: /Account/ChangePassword

        [Authorize]
        public ActionResult ChangePassword()
        {
            return View();
        }

        //
        // POST: /Account/ChangePassword

        [Authorize]
        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordModel model)
        {
            if (ModelState.IsValid)
            {

                // ChangePassword will throw an exception rather
                // than return false in certain failure scenarios.
                bool changePasswordSucceeded;
                try
                {
                    MembershipUser currentUser = Membership.GetUser(User.Identity.Name, true /* userIsOnline */);
                    changePasswordSucceeded = currentUser.ChangePassword(model.OldPassword, model.NewPassword);
                }
                catch (Exception)
                {
                    changePasswordSucceeded = false;
                }

                if (changePasswordSucceeded)
                {
                    return RedirectToAction("ChangePasswordSuccess");
                }
                else
                {
                    ModelState.AddModelError("", "The current password is incorrect or the new password is invalid.");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/ChangePasswordSuccess

        public ActionResult ChangePasswordSuccess()
        {
            return View();
        }

        #region Status Codes
        private static string ErrorCodeToString(MembershipCreateStatus createStatus)
        {
            // See http://go.microsoft.com/fwlink/?LinkID=177550 for
            // a full list of status codes.
            switch (createStatus)
            {
                case MembershipCreateStatus.DuplicateUserName:
                    return "User name already exists. Please enter a different user name.";

                case MembershipCreateStatus.DuplicateEmail:
                    return "A user name for that e-mail address already exists. Please enter a different e-mail address.";

                case MembershipCreateStatus.InvalidPassword:
                    return "The password provided is invalid. Please enter a valid password Value.";

                case MembershipCreateStatus.InvalidEmail:
                    return "The e-mail address provided is invalid. Please check the Value and try again.";

                case MembershipCreateStatus.InvalidAnswer:
                    return "The password retrieval answer provided is invalid. Please check the Value and try again.";

                case MembershipCreateStatus.InvalidQuestion:
                    return "The password retrieval question provided is invalid. Please check the Value and try again.";

                case MembershipCreateStatus.InvalidUserName:
                    return "The user name provided is invalid. Please check the Value and try again.";

                case MembershipCreateStatus.ProviderError:
                    return "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                case MembershipCreateStatus.UserRejected:
                    return "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                default:
                    return "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
            }
        }
        #endregion
    }
}

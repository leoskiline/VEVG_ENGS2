if(localStorage.getItem("role") != "Administrador")
  elems = document.getElementsByClassName("admin");
  for( var e in elems)
    e.style.display = "none";

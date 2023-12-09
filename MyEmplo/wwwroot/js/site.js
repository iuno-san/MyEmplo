
const RenderMyEmploServices = (services, container) => {
    container.empty();

    for (const service of services) {
        container.append(
            `<div class="card border-secondary mb-3" style="max-width: 18rem;">
          <div class="card-header">${service.name}</div>
          <div class="card-body">
            <h5 class="card-title">${service.description}</h5> 
          </div>
        </div>`)
    }
}


const LoadMyEmploServices = () => {
    const container = $("#services")
    const MyEmploEncodedName = container.data("encodedName");

    $.ajax({
        url: `/MyEmplo/${MyEmploEncodedName}/MyEmploService`,
        type: 'get',
        success: function (data) {
            if (!data.length) {
                container.html("Nie masz dodanych dodakowych informacji")
            } else {
                RenderMyEmploServices(data, container)
            }
        },
        error: function () {
            toastr["error"]("coś poszło nie tak")
        }
    })
}

document.addEventListener('DOMContentLoaded', function () {
    var navbarToggle = document.querySelector('.navbar-toggle');
    var navbarMenu = document.querySelector('.navbar-menu');

    navbarToggle.addEventListener('click', function () {
        navbarToggle.classList.toggle('active');
        navbarMenu.classList.toggle('active');
    });
});

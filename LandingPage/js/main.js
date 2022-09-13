$(document).ready(function () {
    for (let i = 1; i <= 3; i++) {
      for (let j = 1; j <= 3; j++) {
        $(".parent").append(
          `<div class="myCard">
            <img src="./img/blog-${j}.png" alt="">
            <span>april 25, 2022</span>
            <p>06 ways to do workout inside your home during Covid-19</p>
          </div>`
        );
      }
    }
  
     $(".myCard").fadeOut();
  
     $(document).scroll(function () {
        var y = $(this).scrollTop();
        if (y < 100) {
           $(".myCard").fadeOut(1000);
        } else {
           $(".myCard").fadeIn(1000);
        }
     });
  
     $(".myCard").click(function () {
      let modal = $(".myModal");
      let imgSource = $(this)[0].children[0].src;
      modal[0].children[0].src = imgSource;
      modal.css("display", "block");
      $(".fadeBackground").css("display", "block");
     });
  
     $(".closeBtn").click(function () {
      $(".myModal").css("display", "none");
      $(".fadeBackground").css("display", "none");
     });
  
     $(".fadeBackground").click(function () {
      $(".myModal").css("display", "none");
      $(".fadeBackground").css("display", "none");
     })
  });
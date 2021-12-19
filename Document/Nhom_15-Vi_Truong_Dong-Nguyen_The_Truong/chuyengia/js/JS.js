var q = 0
var a = 0
var blq = 0
$('#bread5').fadeOut(1000)
$('#bread4').fadeOut(1000)
$('#bread3').fadeOut(1000)
$('#bread2').fadeOut(1000)
$('#bread1').fadeOut(1000)
//FADE ON CLICK + SCROLL
$('#body').click(function () {
  $('#bodyindex').fadeOut(1000)
  $('#bodyindex2').fadeOut(1000)
  $('#SK').delay(500).fadeOut(1000)
  $('#Q1').delay(2000).fadeIn(1000)
  $('#Q1Y').delay(2000).fadeIn(1000)
  $('#Q1N').delay(2000).fadeIn(1000)
  $('#D1').delay(2000).fadeIn(1000)
  $('#term').delay(2000).fadeIn(1000)
  $('#bodyindex').delay(2000).fadeOut(1)
  q = 1
})

//RJ
$('#Q1Y').click(function (event) {
  $('#Q1N').fadeOut(1000)
  $('#Q1').delay(1000).fadeOut(1000)
  $('#Q2').delay(3000).fadeIn(1000)
  $('#Q2Y').delay(3000).fadeIn(1000)
  $('#Q2N').delay(3000).fadeIn(1000)
  q = 2
  b1 = '> Máy bay có cánh quạt'
  b1q = 1
  document.getElementById('bread1').innerHTML = b1
  $('#bread1').fadeIn(1000)
})
$('#Q1N').click(function (event) {
  $('#Q1Y').fadeOut(1000)
  $('#Q1').delay(1000).fadeOut(1000)
  $('#Q9').delay(3000).fadeIn(1000)
  $('#Q9N').delay(3000).fadeIn(1000)
  $('#Q9Y').delay(3000).fadeIn(1000)
  q = 9
  b1 = '> Máy bay có cánh quạt'
  b1q = 1
  document.getElementById('bread1').innerHTML = b1
  $('#bread1').fadeIn(1000)
})
$('#Q2Y').click(function (event) {
  $('#Q2N').fadeOut(1000)
  $('#Q2').delay(1000).fadeOut(1000)
  $('#Q3').delay(3000).fadeIn(1000)
  $('#Q3Y').delay(3000).fadeIn(1000)
  $('#Q3N').delay(3000).fadeIn(1000)
  q = 3
  b2 = '> Máy bay có hai động cơ'
  b2q = 2
  document.getElementById('bread2').innerHTML = b2
  $('#bread2').fadeIn(1000)
})
$('#Q2N').click(function (event) {
  $('#Q2Y').fadeOut(1000)
  $('#Q2').delay(1000).fadeOut(1000)
  $('#Q6').delay(3000).fadeIn(1000)
  $('#Q6Y').delay(3000).fadeIn(1000)
  $('#Q6N').delay(3000).fadeIn(1000)
  q = 6
  b2 = '> Máy bay không có hai động cơ'
  b2q = 2
  document.getElementById('bread2').innerHTML = b2
  $('#bread2').fadeIn(1000)
})
$('#Q3Y').click(function (event) {
  $('#Q3N').fadeOut(1000)
  $('#Q3').delay(1000).fadeOut(1000)
  $('#Q4').delay(3000).fadeIn(1000)
  $('#Q4Y').delay(3000).fadeIn(1000)
  $('#Q4N').delay(3000).fadeIn(1000)
  q = 4
  b3 = '> Bánh xe rút vào gầm'
  b3q = 3
  document.getElementById('bread3').innerHTML = b3
  $('#bread3').fadeIn(1000)
})
$('#Q3N').click(function (event) {
  $('#Q3Y').fadeOut(1000)
  $('#Q3').delay(1000).fadeOut(1000)
  $('#Q5').delay(3000).fadeIn(1000)
  $('#Q5Y').delay(3000).fadeIn(1000)
  $('#Q5N').delay(3000).fadeIn(1000)
  q = 5
  b3 = '> Bánh xe không rút vào gầm'
  b3q = 3
  document.getElementById('bread3').innerHTML = b3
  $('#bread3').fadeIn(1000)
})
$('#Q4Y').click(function (event) {
  $('#Q4N').fadeOut(1000)
  $('#Q4').delay(1000).fadeOut(1000)
  $('#A1').delay(3000).fadeIn(1000)
  q = 17
  a = 1
  b4 = '> Là máy bay cánh cao'
  b4q = 4
  document.getElementById('bread4').innerHTML = b4
  $('#bread4').fadeIn(1000)
  document.getElementById('bread5').innerHTML = '> ATR 72'
  $('#bread5').fadeIn(1000)
})
$('#Q4N').click(function (event) {
  $('#Q4Y').fadeOut(1000)
  $('#Q4').delay(1000).fadeOut(1000)
  $('#A2').delay(3000).fadeIn(1000)
  q = 17
  a = 2
  b4 = '> Không là máy bay cánh cao'
  b4q = 4
  document.getElementById('bread4').innerHTML = b4
  $('#bread4').fadeIn(1000)
  document.getElementById('bread5').innerHTML = '> Piper Seneca'
  $('#bread5').fadeIn(1000)
})
$('#Q5Y').click(function (event) {
  $('#Q5N').fadeOut(1000)
  $('#Q5').delay(1000).fadeOut(1000)
  $('#A3').delay(3000).fadeIn(1000)
  q = 17
  a = 3
  b4 = '> Máy bay có dây buộc phía sau'
  b4q = 5
  document.getElementById('bread4').innerHTML = b4
  $('#bread4').fadeIn(1000)
  document.getElementById('bread5').innerHTML = '> Dash 8 Q400'
  $('#bread5').fadeIn(1000)
})
$('#Q5N').click(function (event) {
  $('#Q5Y').fadeOut(1000)
  $('#Q5').delay(1000).fadeOut(1000)
  $('#A4').delay(3000).fadeIn(1000)
  q = 17
  a = 4
  b4 = '> Máy bay không có dây buộc phía sau'
  b4q = 5
  document.getElementById('bread4').innerHTML = b4
  $('#bread4').fadeIn(1000)
  document.getElementById('bread5').innerHTML = '> Dash 8 Q200'
  $('#bread5').fadeIn(1000)
})
$('#Q6Y').click(function (event) {
  $('#Q6N').fadeOut(1000)
  $('#Q6').delay(1000).fadeOut(1000)
  $('#Q7').delay(3000).fadeIn(1000)
  $('#Q7Y').delay(3000).fadeIn(1000)
  $('#Q7N').delay(3000).fadeIn(1000)
  q = 7
  b3 = '> Máy bay có bánh cố định'
  b3q = 6
  document.getElementById('bread3').innerHTML = b3
  $('#bread3').fadeIn(1000)
})
$('#Q6N').click(function (event) {
  $('#Q6Y').fadeOut(1000)
  $('#Q6').delay(1000).fadeOut(1000)
  $('#Q8').delay(3000).fadeIn(1000)
  $('#Q8Y').delay(3000).fadeIn(1000)
  $('#Q8N').delay(3000).fadeIn(1000)
  q = 8
  b3 = '> Máy bay không có bánh cố định'
  b3q = 6
  document.getElementById('bread3').innerHTML = b3
  $('#bread3').fadeIn(1000)
})
$('#Q7Y').click(function (event) {
  $('#Q7N').fadeOut(1000)
  $('#Q7').delay(1000).fadeOut(1000)
  $('#A5').delay(3000).fadeIn(1000)
  q = 17
  a = 5
  b4 = '> Máy bay có đuôi sau là bánh xe'
  b4q = 7
  document.getElementById('bread4').innerHTML = b4
  $('#bread4').fadeIn(1000)
  document.getElementById('bread5').innerHTML = '> Piper J-3 Cub'
  $('#bread5').fadeIn(1000)
})
$('#Q7N').click(function (event) {
  $('#Q7Y').fadeOut(1000)
  $('#Q7').delay(1000).fadeOut(1000)
  $('#A6').delay(3000).fadeIn(1000)
  q = 17
  a = 6
  b4 = '> Máy bay không có đuôi sau là bánh xe'
  b4q = 7
  document.getElementById('bread4').innerHTML = b4
  $('#bread4').fadeIn(1000)
  document.getElementById('bread5').innerHTML = '> Cessna Skyhawk'
  $('#bread5').fadeIn(1000)
})
$('#Q8Y').click(function (event) {
  $('#Q8N').fadeOut(1000)
  $('#Q8').delay(1000).fadeOut(1000)
  $('#A7').delay(3000).fadeIn(1000)
  q = 17
  a = 7
  b4 = '> Máy bay là loại cánh cao'
  b4q = 8
  document.getElementById('bread4').innerHTML = b4
  $('#bread4').fadeIn(1000)
  document.getElementById('bread5').innerHTML = '> Cessna Caravan'
  $('#bread5').fadeIn(1000)
})
$('#Q8N').click(function (event) {
  $('#Q8Y').fadeOut(1000)
  $('#Q8').delay(1000).fadeOut(1000)
  $('#A8').delay(3000).fadeIn(1000)
  q = 17
  a = 8
  b4 = '> Máy bay không là loại cánh cao'
  b4q = 8
  document.getElementById('bread4').innerHTML = b4
  $('#bread4').fadeIn(1000)
  document.getElementById('bread5').innerHTML = '> Piper Arrow'
  $('#bread5').fadeIn(1000)
})
//COM
$('#Q9Y').click(function (event) {
  $('#Q9N').fadeOut(1000)
  $('#Q9').delay(1000).fadeOut(1000)
  $('#Q10').delay(3000).fadeIn(1000)
  $('#Q10Y').delay(3000).fadeIn(1000)
  $('#Q10N').delay(3000).fadeIn(1000)
  q = 10
  b2 = '> Máy bay có nhiều hơn 12 bánh'
  b2q = 9
  document.getElementById('bread2').innerHTML = b2
  $('#bread2').fadeIn(1000)
})
$('#Q9N').click(function (event) {
  $('#Q9Y').fadeOut(1000)
  $('#Q9').delay(1000).fadeOut(1000)
  $('#Q13').delay(3000).fadeIn(1000)
  $('#Q13Y').delay(3000).fadeIn(1000)
  $('#Q13N').delay(3000).fadeIn(1000)
  q = 13
  b2 = '> Máy bay có ít hơn 12 bánh'
  b2q = 9
  document.getElementById('bread2').innerHTML = b2
  $('#bread2').fadeIn(1000)
})
$('#Q10Y').click(function (event) {
  $('#Q10N').fadeOut(1000)
  $('#Q10').delay(1000).fadeOut(1000)
  $('#Q11').delay(3000).fadeIn(1000)
  $('#Q11Y').delay(3000).fadeIn(1000)
  $('#Q11N').delay(3000).fadeIn(1000)
  q = 11
  b3 = '> Máy bay có một tầng'
  b3q = 10
  document.getElementById('bread3').innerHTML = b3
  $('#bread3').fadeIn(1000)
})
$('#Q10N').click(function (event) {
  $('#Q10Y').fadeOut(1000)
  $('#Q10').delay(1000).fadeOut(1000)
  $('#Q12').delay(3000).fadeIn(1000)
  $('#Q12Y').delay(3000).fadeIn(1000)
  $('#Q12N').delay(3000).fadeIn(1000)
  q = 12
  b3 = '> Máy bay không có một tầng'
  b3q = 10
  document.getElementById('bread3').innerHTML = b3
  $('#bread3').fadeIn(1000)
})
$('#Q11Y').click(function (event) {
  $('#Q11N').fadeOut(1000)
  $('#Q11').delay(1000).fadeOut(1000)
  $('#A9').delay(3000).fadeIn(1000)
  q = 17
  a = 9
  b4 = '> Máy bay có bốn động cơ'
  b4q = 11
  document.getElementById('bread4').innerHTML = b4
  $('#bread4').fadeIn(1000)
  document.getElementById('bread5').innerHTML = '> Airbus A340'
  $('#bread5').fadeIn(1000)
})
$('#Q11N').click(function (event) {
  $('#Q11Y').fadeOut(1000)
  $('#Q11').delay(1000).fadeOut(1000)
  $('#A10').delay(3000).fadeIn(1000)
  q = 17
  a = 10
  b4 = '> Máy bay không có bốn động cơ'
  b4q = 11
  document.getElementById('bread4').innerHTML = b4
  $('#bread4').fadeIn(1000)
  document.getElementById('bread5').innerHTML = '> Boeing 777'
  $('#bread5').fadeIn(1000)
})
$('#Q12Y').click(function (event) {
  $('#Q12N').fadeOut(1000)
  $('#Q12').delay(1000).fadeOut(1000)
  $('#A11').delay(3000).fadeIn(1000)
  q = 17
  a = 11
  b4 = '> Máy bay có hai tầng đầy đủ'
  b4q = 12
  document.getElementById('bread4').innerHTML = b4
  $('#bread4').fadeIn(1000)
  document.getElementById('bread5').innerHTML = '> Airbus A380'
  $('#bread5').fadeIn(1000)
})
$('#Q12N').click(function (event) {
  $('#Q12Y').fadeOut(1000)
  $('#Q12').delay(1000).fadeOut(1000)
  $('#A12').delay(3000).fadeIn(1000)
  q = 17
  a = 12
  b4 = '> Máy bay có hai tầng đầy đủ'
  b4q = 12
  document.getElementById('bread4').innerHTML = b4
  $('#bread4').fadeIn(1000)
  document.getElementById('bread5').innerHTML = '> Boeing 747'
  $('#bread5').fadeIn(1000)
})
$('#Q13Y').click(function (event) {
  $('#Q13N').fadeOut(1000)
  $('#Q13').delay(1000).fadeOut(1000)
  $('#Q14').delay(3000).fadeIn(1000)
  $('#Q14Y').delay(3000).fadeIn(1000)
  $('#Q14N').delay(3000).fadeIn(1000)
  q = 14
  b3 = '> Máy bay có 2 cửa thoát hiểm'
  b3q = 13
  document.getElementById('bread3').innerHTML = b3
  $('#bread3').fadeIn(1000)
})
$('#Q13N').click(function (event) {
  $('#Q13Y').fadeOut(1000)
  $('#Q13').delay(1000).fadeOut(1000)
  $('#Q15').delay(3000).fadeIn(1000)
  $('#Q15Y').delay(3000).fadeIn(1000)
  $('#Q15N').delay(3000).fadeIn(1000)
  q = 15
  b3 = '> Máy bay không có 2 cửa thoát hiểm'
  b3q = 13
  document.getElementById('bread3').innerHTML = b3
  $('#bread3').fadeIn(1000)
})
$('#Q14Y').click(function (event) {
  $('#Q14N').fadeOut(1000)
  $('#Q14').delay(1000).fadeOut(1000)
  $('#A13').delay(3000).fadeIn(1000)
  q = 17
  a = 13
  b4 = '> Máy bay có vây đuôi nhỏ'
  b4q = 14
  document.getElementById('bread4').innerHTML = b4
  $('#bread4').fadeIn(1000)
  document.getElementById('bread5').innerHTML = '> Boeing 737'
  $('#bread5').fadeIn(1000)
})
$('#Q14N').click(function (event) {
  $('#Q14Y').fadeOut(1000)
  $('#Q14').delay(1000).fadeOut(1000)
  $('#A14').delay(3000).fadeIn(1000)
  q = 17
  a = 14
  b4 = '> Máy bay không có vây đuôi nhỏ'
  b4q = 14
  document.getElementById('bread4').innerHTML = b4
  $('#bread4').fadeIn(1000)
  document.getElementById('bread5').innerHTML = '> Airbus A320'
  $('#bread5').fadeIn(1000)
})
$('#Q15Y').click(function (event) {
  $('#Q15N').fadeOut(1000)
  $('#Q15').delay(1000).fadeOut(1000)
  $('#A15').delay(3000).fadeIn(1000)
  q = 17
  a = 15
  b4 = '> Máy bay có 4 động cơ'
  b4q = 15
  document.getElementById('bread4').innerHTML = b4
  $('#bread4').fadeIn(1000)
  document.getElementById('bread5').innerHTML = '> Boeing 787'
  $('#bread5').fadeIn(1000)
})
$('#Q15N').click(function (event) {
  $('#Q15Y').fadeOut(1000)
  $('#Q15').delay(1000).fadeOut(1000)
  $('#A16').delay(3000).fadeIn(1000)
  q = 17
  a = 16
  b4 = '> Máy bay không có 4 động cơ'
  b4q = 15
  document.getElementById('bread4').innerHTML = b4
  $('#bread4').fadeIn(1000)
  document.getElementById('bread5').innerHTML = '> Airbus A330'
  $('#bread5').fadeIn(1000)
})
//END Q and A
//DYNAMIC WHATEVER ITS ACTUALLY CALLED
$('#D1').click(function (event) {
  if (q > 0) {
    $('#Q' + q).fadeOut(1000)
    $('#A' + a).fadeOut(1000)
    $('#D1').fadeOut(1000)
    $('#term').fadeOut(1000)
    $('#bread5').fadeOut(1000)
    $('#bread4').fadeOut(1000)
    $('#bread3').fadeOut(1000)
    $('#bread2').fadeOut(1000)
    $('#bread1').fadeOut(1000)
    $('#bodyindex').delay(2000).fadeIn(1000)
    $('#bodyindex2').delay(2500).fadeIn(1000)
    $('#SK').delay(1500).fadeIn(1000)
    $('#body').delay(1500).fadeIn(1000)
    $('#term').fadeOut(1000)
    $('#back').fadeOut(1000)
    $('#Terminology').fadeOut(1000)
  }
})

$('#bread1').click(function (event) {
  $('#bread5').fadeOut(1000)
  $('#bread4').fadeOut(1000)
  $('#bread3').fadeOut(1000)
  $('#bread2').fadeOut(1000)
  $('#bread1').fadeOut(1000)
  $('#Q' + q).fadeOut(1000)
  $('#A' + a).fadeOut(1000)
  $('#Q' + b1q)
    .delay(2000)
    .fadeIn(1000)
  $('#Q' + b1q + 'N')
    .delay(2000)
    .fadeIn(1000)
  $('#Q' + b1q + 'Y')
    .delay(2000)
    .fadeIn(1000)
  $('#term').fadeIn(1000)
  $('#back').fadeOut(1000)
  $('#Terminology').fadeOut(1000)
  q = b1q
})
$('#bread2').click(function (event) {
  $('#bread5').fadeOut(1000)
  $('#bread4').fadeOut(1000)
  $('#bread3').fadeOut(1000)
  $('#bread2').fadeOut(1000)
  $('#Q' + q).fadeOut(1000)
  $('#A' + a).fadeOut(1000)
  $('#Q' + b2q)
    .delay(2000)
    .fadeIn(1000)
  $('#Q' + b2q + 'N')
    .delay(2000)
    .fadeIn(1000)
  $('#Q' + b2q + 'Y')
    .delay(2000)
    .fadeIn(1000)
  $('#term').fadeIn(1000)
  $('#back').fadeOut(1000)
  $('#Terminology').fadeOut(1000)
  q = b2q
})
$('#bread3').click(function (event) {
  $('#bread5').fadeOut(1000)
  $('#bread4').fadeOut(1000)
  $('#bread3').fadeOut(1000)
  $('#Q' + q).fadeOut(1000)
  $('#A' + a).fadeOut(1000)
  $('#Q' + b3q)
    .delay(2000)
    .fadeIn(1000)
  $('#Q' + b3q + 'N')
    .delay(2000)
    .fadeIn(1000)
  $('#Q' + b3q + 'Y')
    .delay(2000)
    .fadeIn(1000)
  $('#term').fadeIn(1000)
  $('#back').fadeOut(1000)
  $('#Terminology').fadeOut(1000)
  q = b3q
})
$('#bread4').click(function (event) {
  $('#bread5').fadeOut(1000)
  $('#bread4').fadeOut(1000)
  $('#Q' + q).fadeOut(1000)
  $('#A' + a).fadeOut(1000)
  $('#Q' + b4q)
    .delay(2000)
    .fadeIn(1000)
  $('#Q' + b4q + 'N')
    .delay(2000)
    .fadeIn(1000)
  $('#Q' + b4q + 'Y')
    .delay(2000)
    .fadeIn(1000)
  $('#term').fadeIn(1000)
  $('#back').fadeOut(1000)
  $('#Terminology').fadeOut(1000)
  q = b4q
})

$('#term').click(function (event) {
  $('#Q' + q).fadeOut(1000)
  $('#A' + a).fadeOut(1000)
  $('#term').fadeOut(1000)
  $('#back').fadeIn(1000)
  $('#Terminology').fadeIn(1000)
})
$('#back').click(function (event) {
  $('#Q' + q).fadeIn(1000)
  $('#A' + a).fadeIn(1000)
  $('#term').fadeIn(1000)
  $('#back').fadeOut(1000)
  $('#Terminology').fadeOut(1000)
})
$('#help').click(function (event) {
  window.alert(
    'Trợ giúp \nĐể sử dụng hệ thống chuyên gia, hãy làm theo các bước: \n\n1. Nhấp vào bất kỳ văn bản nào trên màn hình chính \n2. Trả lời câu hỏi bằng cách nhấp vào CÓ / KHÔNG \n3. Kết quả sẽ được hiển thị sau khi bốn câu hỏi đã được trả lời \n\n Để quay lại một câu hỏi, hãy nhấp vào câu hỏi bạn muốn quay lại trong thanh điều hướng trên cùng. \n\n Để xem thuật ngữ, hãy nhấp vào nút thuật ngữ ở dưới cùng bên trái góc màn hình. \n\n Để xem menu trợ giúp (menu này), hãy nhấp vào nút trợ giúp ở góc dưới cùng bên phải của màn hình.'
  )
})
// $(document).ready(function () {
//   window.alert(
//     'Trợ giúp \nĐể sử dụng hệ thống chuyên gia, hãy làm theo các bước: \n\n1. Nhấp vào bất kỳ văn bản nào trên màn hình chính \n2. Trả lời câu hỏi bằng cách nhấp vào CÓ / KHÔNG \n3. Kết quả sẽ được hiển thị sau khi bốn câu hỏi đã được trả lời \n\n Để quay lại một câu hỏi, hãy nhấp vào câu hỏi bạn muốn quay lại trong thanh điều hướng trên cùng. \n\n Để xem thuật ngữ, hãy nhấp vào nút thuật ngữ ở dưới cùng bên trái góc màn hình. \n\n Để xem menu trợ giúp (menu này), hãy nhấp vào nút trợ giúp ở góc dưới cùng bên phải của màn hình.'
//   )
// })
// SCROLL LOCK - NO NEED
//if ($(document).height() > $(window).height()) {
//     scrollTop = ($('html').scrollTop()) ? $('html').scrollTop() : $('body').scrollTop(); // Works for Chrome, Firefox, IE...
//     $('html').addClass('noscroll').css('top',-scrollTop);
//}

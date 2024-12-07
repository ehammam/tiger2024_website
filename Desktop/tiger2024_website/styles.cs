/* تعيين الهوامش والتباعد الافتراضي لجميع العناصر */
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

/* تنسيق الجسم (body) */
body {
    font-family: Arial, sans-serif;
    background-color: #f4f4f4;
    color: #333;
}

/* تنسيق رأس الصفحة (header) */
header {
    background-color: #4CAF50;
    color: white;
    padding: 20px;
    text-align: center;
}

/* تنسيق القوائم في الشريط العلوي */
header nav ul {
    list-style-type: none;
    padding: 0;
}

header nav ul li {
    display: inline;
    margin: 0 15px;
}

header nav ul li a {
    color: white;
    text-decoration: none;
    font-size: 18px;
}

/* تنسيق الأقسام */
section {
    margin: 20px;
    padding: 20px;
    background-color: white;
    border-radius: 8px;
    box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
}

/* تنسيق تذييل الصفحة (footer) */
footer {
    background-color: #333;
    color: white;
    text-align: center;
    padding: 10px;
    position: fixed;
    width: 100%;
    bottom: 0;
}

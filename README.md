# جعبه ابزار اعتبار سنجی

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)

جعبه ابزاری برای اعتبار سنجی برخی مقادیر مربوط به کشور ایران.
# اعتبار سنجی

  - اعتبار سنجی شماره موبایل به تفکیک نام اپراتور(همراه اول - ایرانسل - رایتل)
  - اعتبار سنجی کد ملی افراد
  - اعتبار سنجی شناسه ملی شرکت ها
  - اعتبار سنجی شماره کارت های بانکی
  - اعتبار سنجی مقادیر شبکه و اینترنت(ایمیل - آی پی ها - آدرس های اینترنتی)


به زودی قابلیت های جدید افزوده خواهد شد.

### نصب
نصب این بسته به راحتی از طریق NuGet امکان پذیر است.
برای نصب از دستور زیر استفاده کنید:
```sh
Install-Package IraniValidator.core -Version 1.2.0 
```

### راهنمای استفاده

این بسته شامل تعدادی اکستنشن متد برای اعتبار سنجی رشته ها است.
نمونه کد:
```sh
            string test = "09191234567";

            var isIraniMobile = test.IsValidMobile(); //return true

            var isIrancell = test.IsValidMobile(OpratorType.IranCell); //return false


            string test1 = "3962619771";

            var isNationalId = test1.IsValidPersonNationalId(); //return true

            var isCompanyNationalId = test1.IsValidCompanyNationalId(); //return false

            var isCreditNumber = test1.IsValidCreditCard(); //return false


            string test2 = "test@gmail.com";

            var isEmail = test2.IsValidEmailAddress();  //return 


            //and so on...
```



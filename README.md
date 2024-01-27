<p align="center"><h1>WordSearchEngine</h1></p>
 <p align="center">
  <a>
    <img alt="Last Commit" src="https://img.shields.io/github/last-commit/AlexScience/WordSearchEngine?logo=Mapbox&color=orange">
  </a>
  <a>
    <img alt="Repo Size" src="https://img.shields.io/github/repo-size/AlexScience/WordSearchEngine?logo=VirtualBox">
  </a>
  <a>
    <img alt="Downloads" src="https://img.shields.io/github/downloads/AlexScience/WordSearchEngine/total?color=brightgreen">
  </a>
  <a>
    <img alt="Last Release" src="https://img.shields.io/github/v/release/AlexScience/WordSearchEngine?include_prereleases&logo=Dropbox&color=yellow">
  </a>
  <a>
    <img alt="GitHub stars" src="https://img.shields.io/github/stars/AlexScience/WordSearchEngine?branch=main&label=Stars&logo=GitHub&logoColor=ffffff&labelColor=282828&color=informational&style=flat">
  </a>
  <a>
    <img alt="GitHub user stars" src="https://img.shields.io/github/stars/AlexScience?affiliations=OWNER&branch=main&label=User%20Stars&logo=GitHub&logoColor=ffffff&labelColor=282828&color=informational&style=flat">
  </a>
  <a>
    <img alt="" src="https://img.shields.io/github/watchers/AlexScience/WordSearchEngine?style=flat">
  </a>
</p>

## Описание
WordSearchEngine - это консольное приложение на C#, предназначенное для поиска слов в текстовых файлах. Программа позволяет пользователю указать путь к текстовому файлу и искомое слово, а затем выводит строки, в которых это слово встречается, вместе с номерами строк. Пользователь также может выбрать, искать ли все вхождения слова или только первое.

## Как это работает
Приложение запрашивает у пользователя путь к текстовому файлу и слово для поиска. Затем оно читает файл построчно и ищет указанное слово в каждой строке. Если слово найдено, программа выводит эту строку на экран вместе с её номером. Пользователь может выбрать, продолжить ли поиск после нахождения первого вхождения слова.

## Установка
Для использования WordSearchEngine необходимо склонировать репозиторий на свой компьютер. Убедитесь, что у вас установлен .NET SDK.

1. Откройте терминал.
2. Клонируйте репозиторий с помощью команды:```git clone https://github.com/AlexScience/WordSearchEngine.git```
3. Перейдите в папку проекта: ```cd WordSearchEngine```

## Использование
Чтобы запустить приложение, выполните следующие шаги:

1. В терминале перейдите в папку с проектом.
2. Запустите приложение с помощью команды: ```dotnet run```

После запуска следуйте инструкциям на экране:

1. Введите путь к файлу, который вы хотите исследовать.
2. Введите искомое слово.
3. Выберите, хотите ли вы искать все вхождения слова (введите "Y") или только первое (введите "N").

## Лицензия
Этот проект распространяется под [MIT License](LICENSE).

## Автор
[`AlexScience`](https://github.com/AlexScience) - Alexey

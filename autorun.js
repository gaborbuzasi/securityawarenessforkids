let path = window.location.href;

const websiteDomain = "https://yourwebsitesname.net";

if (path.includes("gmail") || path.includes("mail"))
{
    window.open(websiteDomain + '?d=gmail', '_blank');
}
else if (path.includes("facebook"))
{
    window.open(websiteDomain + '?d=facebook', '_blank');
}
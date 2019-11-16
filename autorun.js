let path = window.location.href;

let trustedList = [
    "facebook.com"
];

let blockedList = [
    "instagram.com"
];

const websiteDomain = "https://yourwebsitesname.net";

window.onload = function () {
    var anchorTags = document.getElementsByTagName('a');

    for(i = 0; i < anchorTags.length; i++)
    {
        let anchor = anchorTags[i];
        
        if (trustedList.some(t => anchor.href.toLowerCase().includes(t.toLowerCase()))) 
        {
            let sp = document.createElement('a');
            sp.setAttribute('title', 'Open minigame')
            sp.setAttribute('href', 'randomgamenotreadyyet');
            sp.setAttribute('style', 'text-decoration: none;');
            sp.setAttribute('target', '_blank');
            sp.innerHTML = '🐤';

            anchor.parentNode.appendChild(sp);
        }
        else if (blockedList.some(b => anchor.href.toLowerCase().includes(b.toLowerCase())))
        {
            anchor.href = '#';
            let sp = document.createElement('a');
            sp.setAttribute('title', 'Open minigame')
            sp.setAttribute('href', 'randomgamenotreadyyet');
            sp.setAttribute('style', 'text-decoration: none;');
            sp.setAttribute('target', '_blank');
            
            // Google uses ping to redirect to page
            sp.setAttribute('ping', '#');
            sp.innerHTML = '🦞';

            anchor.parentNode.appendChild(sp);
        }
    }
}
// if (path.includes("gmail") || path.includes("mail"))
// {
//     window.open(websiteDomain + '?d=gmail', '_blank');
// }
// else if (path.includes("facebook"))
// {
//     window.open(websiteDomain + '?d=facebook', '_blank');
// }
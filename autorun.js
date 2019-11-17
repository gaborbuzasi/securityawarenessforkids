/*
if(window.location.toString().includes("google")){
    // update the logo
    chrome.runtime.sendMessage({
        action: 'updateIcon',
        value: true
    });
}else{
    // update the logo
    chrome.runtime.sendMessage({
        action: 'updateIcon',
        value: false
    });
}
*/
/*

let path = window.location.href;

let trustedList = [
    "www.facebook.com"
];

let blockedList = [
    "www.instagram.com"
];

const websiteDomain = "https://yourwebsitesname.net";

window.onload = function () {
    

    var anchorTags = [].filter.call(document.getElementsByTagName('a'), el => !el.hasAttribute('custom'));

    for(i = 0; i < anchorTags.length; i++)
    {
        let anchor = anchorTags[i];
        let sp = document.createElement('a');

        sp.setAttribute('custom', true);

        if (trustedList.some(t => anchor.href.toLowerCase().includes(t.toLowerCase()))) 
        {
            sp.setAttribute('title', 'Site is trusted')
            sp.setAttribute('href', 'randomgamenotreadyyet');
            sp.setAttribute('style', 'text-decoration: none;');
            sp.setAttribute('target', '_blank');
            sp.innerHTML = '🐤';
        }
        else if (blockedList.some(b => anchor.href.toLowerCase().includes(b.toLowerCase())))
        {
            anchor.href = '#';

            sp.setAttribute('title', 'Site is harmful');
            sp.setAttribute('href', 'randomgamenotreadyyet');
            sp.setAttribute('style', 'text-decoration: none;');
            sp.setAttribute('target', '_blank');
            
            // Google uses ping to redirect to page
            sp.setAttribute('ping', '#');

            sp.innerHTML = '🦞';
        }
        else 
        {
            sp.setAttribute('title', 'Site could be harmful')
            sp.setAttribute('href', 'randomgamenotreadyyet');
            sp.setAttribute('style', 'text-decoration: none;');
            sp.setAttribute('target', '_blank');
            //sp.innerHTML = '🐍';

            sp.innerHTML = '🦞';
        }

        anchor.parentNode.appendChild(sp);
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

*/
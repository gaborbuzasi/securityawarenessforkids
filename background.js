const MALWARE_JUMP_MATHING_URL = "facebook.com";
const UNSAFE_NET_MATCHING_URL = "iltalehti.fi";
const MALWARE_JUMP_URL = "http://localhost:8000/";
const UNSAFE_NET_URL = "http://is.fi";

// sets the correct icon
chrome.tabs.onActivated.addListener(function(info) {
    var tab = chrome.tabs.get(info.tabId, function(tab) {
        if(tab.url.includes(MALWARE_JUMP_MATHING_URL)){
            chrome.browserAction.setIcon({path: "images/duck128.png"});
            malware_game = true;
        }else if(tab.url.includes(UNSAFE_NET_MATCHING_URL)){
            chrome.browserAction.setIcon({path: "images/duck128.png"});
            malware_game = false;
        }else{
            chrome.browserAction.setIcon({path: "images/duck128g.png"});
        }
    });
});

//open the correct url when icon is clicked
chrome.browserAction.onClicked.addListener(function(activeTab){
    chrome.tabs.getSelected(null, function(tab) {
        if(tab.url.includes(MALWARE_JUMP_MATHING_URL)){
            chrome.tabs.create({ url: MALWARE_JUMP_URL });
        }else if(tab.url.includes(UNSAFE_NET_MATCHING_URL)){
            chrome.tabs.create({ url: UNSAFE_NET_URL });
        }else{
            
        }
    });
});

<!DOCTYPE html>
<html lang='zh-CN'>
<head>
<title>README.md · 一醉倾城/DomainRouteMiddleware - Gitee.com</title>
<meta content='on' http-equiv='x-dns-prefetch-control'>
<link href='//e.gitee.com' rel='dns-prefetch'>
<link href='//files.gitee.com' rel='dns-prefetch'>
<link href='//toscode.gitee.com' rel='dns-prefetch'>
<link href='https://assets.gitee.com' rel='dns-prefetch'>
<link href='https://portrait.gitee.com' rel='dns-prefetch'>
<link rel="shortcut icon" type="image/vnd.microsoft.icon" href="https://assets.gitee.com/assets/favicon-9007bd527d8a7851c8330e783151df58.ico" />
<link rel="canonical" href="https://gitee.com/yzqc/DomainRouteMiddleware" />
<meta content='gitee.com/yzqc/DomainRouteMiddleware git https://gitee.com/yzqc/DomainRouteMiddleware.git' name='go-import'>
<meta charset='utf-8'>
<meta content='always' name='referrer'>
<meta content='Gitee' property='og:site_name'>
<meta content='Object' property='og:type'>
<meta content='http://gitee.com/yzqc/DomainRouteMiddleware/blob/master/README.md' property='og:url'>
<meta content='https://gitee.com/static/images/logo_themecolor.png' itemprop='image' property='og:image'>
<meta content='README.md · 一醉倾城/DomainRouteMiddleware - Gitee.com' itemprop='name' property='og:title'>
<meta content='域名路由中间件可以控制不同的域名，来指向不同的静态资源目录，不需要在域名后面指定具体哪个目录。' property='og:description'>
<meta content='码云,Gitee,代码托管,Git,Git@OSC,Gitee.com,开源,内源,项目管理,版本控制,开源代码,代码分享,项目协作,开源项目托管,免费代码托管,Git代码托管,Git托管服务' name='Keywords'>
<meta content='域名路由中间件可以控制不同的域名，来指向不同的静态资源目录，不需要在域名后面指定具体哪个目录。' itemprop='description' name='Description'>

<meta content="IE=edge" http-equiv="X-UA-Compatible" />
<meta name="csrf-param" content="authenticity_token" />
<meta name="csrf-token" content="TzSGNW7OC2ytrQCJuKLVDFxMYkQ5t6x1xehPLFK1S+EOpoTK4/GPPkNn8oS5I3KDTOMTA6UcTj0qpnn/5iHeeQ==" />

<link rel="stylesheet" media="all" href="https://assets.gitee.com/assets/application-73b00178a8a742f63ae489d1c8dd8a74.css" />
<script>
//<![CDATA[
window.gon = {};gon.locale="zh-CN";gon.sentry_dsn=null;gon.baidu_register_hm_push=null;gon.sensor={"server_url":"https://haveaniceday.gitee.com:3443/sa?project=production","page_type":"其他"};gon.info={"controller_path":"blob","action_name":"show","current_user":{"id":128998,"name":"一醉倾城","username":"yzqc","official":false,"admin":false,"avatar_url":"no_portrait.png#一醉倾城-yzqc"}};gon.tour_env={"current_user":"yzqc","action_name":"show","original_url":"http://gitee.com/yzqc/DomainRouteMiddleware/blob/master/README.md","controller_path":"blob"};gon.http_clone="https://gitee.com/yzqc/DomainRouteMiddleware.git";gon.user_project="yzqc/DomainRouteMiddleware";gon.manage_branch="管理分支";gon.manage_tag="管理标签";gon.enterprise_id=0;gon.create_reaction_path="/yzqc/DomainRouteMiddleware/reactions";gon.ref="master";
//]]>
</script>
<script src="https://assets.gitee.com/assets/static/sensor-42ae731632c43f0efd3963709358d23f.js"></script>
<script src="https://assets.gitee.com/assets/static/sentry-5.1.0-a823fb0be1b61c5d7ca4a89f0536cb0a.js"></script>
<script src="https://assets.gitee.com/assets/application-800e99e9d24559db8333e941f3022eb9.js"></script>
<script src="https://assets.gitee.com/assets/lib/jquery.timeago.zh-CN-4a4818e98c1978d2419ab19fabcba740.js"></script>

<link rel="stylesheet" media="all" href="https://assets.gitee.com/assets/projects/application-705b8d764a3d4201795216aad0ed4b70.css" />
<script src="https://assets.gitee.com/assets/projects/app-a36de682149421cdbc6b6678d151af1a.js"></script>

<script src="//res.wx.qq.com/open/js/jweixin-1.2.0.js"></script>
<script>
  var title = document.title.replace(/( - Gitee| - 码云)$/, '')
      imgUrl = '';
  
  document.addEventListener('DOMContentLoaded', function(event) {
    var imgUrlEl = document.querySelector('.readme-box .markdown-body > img, .readme-box .markdown-body :not(a) > img');
    imgUrl = imgUrlEl && imgUrlEl.getAttribute('src');
  
    if (!imgUrl) {
      imgUrlEl = document.querySelector('meta[itemprop=image]');
      imgUrl = imgUrlEl && imgUrlEl.getAttribute('content');
      imgUrl = imgUrl || "https://gitee.com/static/images/logo_themecolor.png";
    }
  
    wx.config({
      debug: false,
      appId: "wxff219d611a159737",
      timestamp: "1639552093",
      nonceStr: "c612c3a85e2e6ec1e2fdf475250b988f",
      signature: "f204334b3401c5baab33e65471e3ef6c68c414ae",
      jsApiList: [
        'onMenuShareTimeline',
        'onMenuShareAppMessage'
      ]
    });
  
    wx.ready(function () {
      wx.onMenuShareTimeline({
        title: title, // 分享标题
        link: "https://gitee.com/yzqc/DomainRouteMiddleware/blob/master/README.md", // 分享链接，该链接域名或路径必须与当前页面对应的公众号JS安全域名一致
        imgUrl: imgUrl // 分享图标
      });
      wx.onMenuShareAppMessage({
        title: title, // 分享标题
        link: "https://gitee.com/yzqc/DomainRouteMiddleware/blob/master/README.md", // 分享链接，该链接域名或路径必须与当前页面对应的公众号JS安全域名一致
        desc: document.querySelector('meta[name=Description]').getAttribute('content'),
        imgUrl: imgUrl // 分享图标
      });
    });
    wx.error(function(res){
      console.error('err', res)
    });
  })
</script>

<script type='text/x-mathjax-config'>
MathJax.Hub.Config({
  tex2jax: {
    inlineMath: [['$','$'], ['\\(','\\)']],
    displayMath: [["$$","$$"],["\\[","\\]"]],
    processEscapes: true,
    skipTags: ['script', 'noscript', 'style', 'textarea', 'pre', 'code'],
    ignoreClass: "container|files",
    processClass: "markdown-body"
  }
});
</script>
<script src="https://assets.gitee.com/uploads/resources/MathJax-2.7.2/MathJax.js?config=TeX-AMS-MML_HTMLorMML"></script>

<script>
  (function () {
    var messages = {
      'zh-CN': {
        addResult: '增加 <b>{term}</b>',
        count: '已选择 {count}',
        maxSelections: '最多 {maxCount} 个选择',
        noResults: '未找到结果',
        serverError: '连接服务器时发生错误'
      },
      'zh-TW': {
        addResult: '增加 <b>{term}</b>',
        count: '已選擇 {count}',
        maxSelections: '最多 {maxCount} 個選擇',
        noResults: '未找到結果',
        serverError: '連接服務器時發生錯誤'
      }
    }
  
    if (messages[gon.locale]) {
      $.fn.dropdown.settings.message = messages[gon.locale]
    }
  }());
</script>

<script>
  var userAgent = navigator.userAgent;
  var isLessIE11 = userAgent.indexOf('compatible') > -1 && userAgent.indexOf('MSIE') > -1;
  if(isLessIE11){
    var can_access = ""
    if (can_access != "true"){
      window.location.href = "/incompatible.html";
    }
  }
  document.addEventListener("error", function (ev) {
    var elem = ev.target;
    if (elem.tagName.toLowerCase() === 'img') {
      elem.src = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAMgAAADICAAAAACIM/FCAAACh0lEQVR4Ae3ch5W0OgyG4dt/mQJ2xgQPzJoM1m3AbALrxzrf28FzsoP0HykJEEAAAUQTBBBAAAEEEEAAAQQQQAABBBBAAAEEEEAAAQQQQAABBBBAAAEEkKK0789+GK/I2ezfQB522PnS1qc8pGgXvr4tE4aY0XOUWlGImThWgyCk6DleixzE7qwBkg/MGiDPlVVAyp1VQGrPKiACDhFI6VkF5LmzCki+sg7IwDoglnVAil0IMkeG9CyUiwsxLFUVFzJJOQaKCjFCDN9RXMjIX7W6ztZXZDKKCyn8sWJvH+nca7WHDN9lROlAliPH9iRKCPI4cswFJQWxB46toLQgQ9jhn5QYZA9DOkoMUoQde5YapAxDWkoNYsOQR3KQd9CxUnIQF4S49CB9ENKlBxmDEKsFUgMCCCCAAHIrSF61f6153Ajy8nyiPr8L5MXnmm4CyT2fzN4DUvHZ+ntA2tOQBRBAAAEEEEAAAQQQ7ZBaC6TwSiDUaYHQ2yuB0MN+ft+43whyrs4rgVCjBUKTFshLC6TUAjGA3AxSaYFYLZBOC2RUAsk8h5qTg9QcbEoOsoQhQ2qQhsO5xCD5dgB5JQaZ+KBKGtKecvR81Ic0ZDjByKdDx0rSEDZ/djQbH+bkIdvfJFm98BfV8hD2zprfVdlu9PxVeyYAkciREohRAplJCaRSAplJCcQogTjSAdlyHRBvSAekJR0QRzogA+mADJkOiCPSAPEtqYBshlRAXC43hxix2QiOuEZkVERykGyNo9idIZKE0HO7XrG6OiMShlDWjstVzdPgXtUH9v0CEidAAAEEEEAAAQQQQAABBBBAAAEEEEAAAQQQQAABBBBAAAEEEEAAAQQQQP4HgjZxTpdEii0AAAAASUVORK5CYII=";
    }
  }, true);
</script>
</head>

<body class='git-project lang-zh-CN large'>
<header class='common-header fixed noborder' id='git-header-nav'>
<div class='ui container'>
<div class='ui menu header-menu header-container'>
<div class='git-nav-expand-bar'>
<i class='iconfont icon-mode-table'></i>
</div>
<div class='gitee-nav__sidebar'>
<div class='gitee-nav__sidebar-container'>
<div class='gitee-nav__sidebar-top'>
<div class='gitee-nav__avatar-box'>
<a href="/yzqc"><img class="ui avatar image yzqc-avatar" avatar="一醉倾城-yzqc" />
</a></div>
<div class='gitee-nav__info-box'>
<a href="/yzqc">一醉倾城</a>
</div>
</div>
<div class='gitee-nav__sidebar-middle'>
<div class='gitee-nav__sidebar-list'>
<ul>
<li class='gitee-nav__sidebar-item'>
<a href="/yzqc"><i class='iconfont icon-ic-dashboard'></i>
<span class='gitee-nav__sidebar-name'>个人主页</span>
</a></li>
<li class='gitee-nav__sidebar-item'>
<a href="/explore"><i class='iconfont icon-ic-discover'></i>
<span class='gitee-nav__sidebar-name'>开源软件</span>
</a></li>
<li class='gitee-nav__sidebar-item'>
<a href="/enterprises"><i class='iconfont icon-ic-enterprise'></i>
<span class='gitee-nav__sidebar-name'>企业版</span>
</a></li>
<li class='gitee-nav__sidebar-item'>
<a href="/education"><i class='iconfont icon-ic-education'></i>
<span class='gitee-nav__sidebar-name'>高校版</span>
</a></li>
<li class='gitee-nav__sidebar-item split-line'></li>
<li class='gitee-nav__sidebar-item'>
<a href="/search"><i class='iconfont icon-ic-search'></i>
<span class='gitee-nav__sidebar-name'>搜索</span>
</a></li>
<li class='gitee-nav__sidebar-item'>
<a href="/help"><i class='iconfont icon-help-circle'></i>
<span class='gitee-nav__sidebar-name'>帮助中心</span>
</a></li>
<li class='gitee-nav__sidebar-item'>
<a href="/terms"><i class='iconfont icon-file'></i>
<span class='gitee-nav__sidebar-name'>使用条款</span>
</a></li>
<li class='gitee-nav__sidebar-item'>
<a href="/about_us"><i class='iconfont icon-issuepx'></i>
<span class='gitee-nav__sidebar-name'>关于我们</span>
</a></li>
<li class='gitee-nav__sidebar-item'>
<a href="/profile/account_information"><i class='iconfont icon-edit'></i>
<span class='gitee-nav__sidebar-name'>设置</span>
</a></li>
<li class='gitee-nav__sidebar-item'>
<a rel="nofollow" data-method="delete" href="/logout"><i class='iconfont icon-ic-logout'></i>
<span class='gitee-nav__sidebar-name'>
退出
</span>
</a></li>
</ul>
</div>
</div>
<div class='gitee-nav__sidebar-bottom'>
<div class='gitee-nav__sidebar-close-button'>
<i class='fa fa-angle-double-left'></i>
</div>
</div>
</div>
</div>

<div class='item gitosc-logo'>
<a href="/"><img alt='Gitee — 基于 Git 的代码托管和研发协作平台' class='ui inline image' height='28' src='/static/images/logo.svg?t=158106664' title='Gitee — 基于 Git 的代码托管和研发协作平台' width='95'>
<img alt='Gitee — 基于 Git 的代码托管和研发协作平台' class='ui inline black image' height='28' src='/static/images/logo-black.svg?t=158106664' title='Gitee — 基于 Git 的代码托管和研发协作平台' width='95'>
</a></div>
<a title="开源软件" class="item " href="/explore">开源软件
</a><a title="企业版" class="item " href="/enterprises">企业版
<sup class='ui red label'>
特惠
</sup>
</a><a title="高校版" class="item " href="/education">高校版
</a><a title="私有云" class="item" target="_blank" href="https://gitee.cn?utm_source=giteecom">私有云
</a><a title="博客" class="item" id="gitee-blog" target="_blank" href="https://blog.gitee.com/?utm_sources=site_nav">博客
</a><div class='dropdown item loading ui' id='my-gitee-dropdown'>
<a href="/">我的</a>
<i class='dropdown icon'></i>
<div class='menu'>
<div class='header user-enterprises'>
<a class="pull-right" target="_blank" href="/yzqc/dashboard/enterprises">全部</a>
企业
<span class='count'></span>
</div>
<div class='disabled item tip user-enterprises'>
无企业
</div>
<div class='header user-groups'>
<a class="pull-right" target="_blank" href="/yzqc/dashboard/groups">全部</a>
组织
<span class='count'></span>
</div>
<div class='disabled item tip user-groups'>
无组织
</div>
<div class='header user-programs'>
项目
<span class='count'></span>
</div>
<div class='disabled item tip user-programs'>
<span class="translation_missing" title="translation missing: zh-CN.layouts.header.empty_programs">Empty Programs</span>
</div>
<div class='header user-projects'>
<a class="pull-right" target="_blank" href="/yzqc/projects">全部</a>
仓库
<span class='count'></span>
</div>
<div class='disabled item tip user-projects'>
无项目
</div>
</div>
</div>
<div class='center responsive-logo'>
<a href="/"><img alt='Gitee — 基于 Git 的代码托管和研发协作平台' class='ui inline image' height='24' src='/static/images/logo.svg?t=158106664' title='Gitee — 基于 Git 的代码托管和研发协作平台' width='85'>
<img alt='Gitee — 基于 Git 的代码托管和研发协作平台' class='ui inline black image' height='24' src='/static/images/logo-black.svg?t=158106664' title='Gitee — 基于 Git 的代码托管和研发协作平台' width='85'>
</a></div>
<div class='right menu userbar right-header' id='git-nav-user-bar'>
<form class="ui item" id="navbar-search-form" data-text-require="搜索关键字不能少于1个" data-text-filter="搜索格式不正确" action="/search" accept-charset="UTF-8" method="get"><input name="utf8" type="hidden" value="&#x2713;" />
<input type="hidden" name="type" id="navbar-search-type" />
<input type="hidden" name="fork_filter" id="fork_filter" value="on" />
<div class='ui search header-search'>
<input type="text" name="q" id="navbar-search-input" value="" class="prompt" placeholder="搜开源" />
</div>
</form>

<script>
  var can_search_in_repo = 1,
      repo = "VFZSck5FMVVZekZQVkdSb1RucFplbHBuUFQxaE56WXpaZz09YTc2M2Y=",
      reponame = "yzqc/DomainRouteMiddleware";
  
  $(function() {
    var $search = $('#navbar-search-form .ui.search');
    $search.search({
      apiSettings: {
        url: '/search/relative_project?q={query}',
        onResponse: function (res) {
          if (res && res.status === 200 && res.data) {
            var query = htmlSafe($search.search('get value'));
  
            res.data.map(function (item) {
              item.path_ns = '/' + item.path_ns;
              item.icon = 'iconfont icon-project-public';
            });
            res.data.unshift({
              name_ns: "在全站搜索 <b class='hl'>" + query +"</b> 相关项目",
              path_ns: '/search?fork_filter=on&q=' + query,
              icon: 'iconfont icon-search'
            });
            return res;
          } else {
            return { data: [] };
          }
        }
      },
      fields: {
        results: 'data',
        description: 'name_ns',
        url: 'path_ns',
        icon: 'icon'
      },
      minCharacters: 1,
      maxResults: 10,
      searchDelay: 250,
      showNoResults: false,
      transition: 'fade'
    });
  });
</script>

<div class='item ui dropdown empty' data-count-path='/notifications/unread_count' data-enable data-mark-notice-path='/notifications/mark' id='notice-dropdown'>
<a class="remind-button" href="/notifications"><i class='iconfont icon-remind'></i>
<div class='notice-count total'></div>
</a><div class='notice-dropdown-panel menu'>
<div class='notice-dropdown-panel-header'>
<div class='tab active' data-data-path='/notifications/notices?scope=referer' data-html-path='/notifications/referer' data-scope='referer'>
<div class='content'>
@ 我
<div class='notice-count referer'></div>
</div>
</div>
<div class='tab' data-data-path='/notifications/notices?scope=infos' data-html-path='/notifications/infos' data-scope='infos'>
<div class='content'>
通知
<div class='notice-count infos'></div>
</div>
</div>
<div class='tab' data-data-path='/notifications/notices?scope=messages' data-html-path='/notifications/messages' data-scope='messages'>
<div class='content'>
私信
<div class='notice-count messages'></div>
</div>
</div>
</div>
<div class='item notice-dropdown-panel-container'>
<div class='ui dimmer over active'>
<div class='ui loader'></div>
</div>
<div class='notice-list'></div>
<div class='notice-dropdown-panel-blank'>
暂没有新消息
</div>
</div>
<div class='notice-dropdown-panel-footer'>
<div class='action'>
<div class='side left'>
<a class="mark-notices" href="javascript: void(0);">当前标记为已读
</a></div>
<div class='side right'>
<a class="load-all" target="_blank" href="javascript: void(0);">查看全部
</a></div>
</div>
</div>
</div>
</div>

<div class='ui item' id='feature-update-notice'>
<div class='notice-update-icon'>
<a class="notice-update-popup click-knowed" title="" href="javascript:void(0)"><img alt="功能更新" title="" class="bubl_icon bubl-off-icon" src="https://assets.gitee.com/assets/bulb_off-24ee940be20998aace89a3f040cbc704.svg" />
<img alt="功能更新" title="" class="bubl_icon bubl-on-icon" src="https://assets.gitee.com/assets/bulb_on-3986b1dc417285398e3d15671bd8f261.svg" />
</a></div>
<div class='feature-update-notice-panel menu'>
<div class='notice-img'>
<img alt="" title="" class="notice-img-show" src="" />
</div>
<div class='notice-update-title'></div>
<div class='notice-update-des'></div>
<div class='notice-btn-list d-flex-between'>
<button name="button" type="button" class="ui basic orange button btn-notice btn-knowed click-knowed" style="margin-right: 0">我知道了</button>
<a class="ui button orange btn-notice btn-details click-knowed" target="_blank" href="">查看详情</a>
</div>
</div>
</div>

<div class='ui dropdown link item' id='git-nav-create'>
<i class='iconfont icon-add-thin'></i>
<div class='right menu'>
<a class="item" href="/projects/new"><i class='add square icon'></i>
新建仓库
</a><a class="item" href="/yzqc/codes/new"><i class='code icon'></i>
发布代码片段
</a><a class="item" href="/organizations/new"><i class='group icon'></i>
创建组织
</a><a class="item" href="/enterprises/new"><i class='icon iconfont icon-enterprise'></i>
开通企业版
</a><a class="item" href="/projects/import/url"><i class='github icon'></i>
从 GitHub / GitLab 导入仓库
</a></div>
</div>
<div class='ui dropdown item' id='git-nav-user'>
<img class="ui avatar image" avatar="一醉倾城-yzqc" />
<i class='dropdown icon'></i>
<div class='right menu'>
<a class="item" href="/yzqc"><i class='iconfont icon-ic-home'></i>
个人主页
</a><a class="item" href="/yzqc/starred"><i class='iconfont icon-star'></i>
我的星选集
</a><a class="item" href="/profile/account_information"><div class='mayun-icon my-ic-edit my-ic-edit-dims'></div>
设置
</a><div class='divider'></div>
<a class="item" target="_blank" href="https://gitee.com/help"><div class='mayun-icon my-ic-help my-ic-help-dims'></div>
帮助
</a><div class='divider'></div>
<a class="item destroy-user-session" rel="nofollow" data-method="delete" href="/logout"><div class='mayun-icon my-ic-exit my-ic-exit-dims'></div>
退出
</a></div>
</div>
<script>
  $('.destroy-user-session').on('click', function() {
    $.cookie('access_token', null, { path: '/' });
  })
</script>

</div>
</div>
</div>
</header>
<script>
  Gitee.initNavbar()
  Gitee.initRepoRemoteWay()
  $.cookie('user_locale',null)
</script>

<script>
  var userAgent = navigator.userAgent;
  var isLessIE11 = userAgent.indexOf('compatible') > -1 && userAgent.indexOf('MSIE') > -1;
  if(isLessIE11){
    var can_access = ""
    if (can_access != "true"){
      window.location.href = "/incompatible.html";
    }
  }
</script>

<div class='fixed-notice-infos'>
<div class='all-messages'>
</div>
<div class='ui container'>
<div class='flash-messages' id='messages-container'></div>
</div>
<script>
  (function() {
    $(function() {
      var $error_box, alertTip, notify_content, notify_options, template;
      template = '<div data-notify="container" class="ui {0} message" role="alert">' + '<i data-notify="dismiss" class="close icon"></i>' + '<span data-notify="message">{2}</span>' + '</div>';
      notify_content = null;
      notify_options = {};
      alertTip = '';
      $error_box = $(".flash_error.flash_error_box");
      if (notify_options.type === 'error' && $error_box.length > 0 && !$.isEmptyObject(notify_content.message)) {
        if (notify_content.message === 'captcha_fail') {
          alertTip = "验证码不正确";
        } else if (notify_content.message === 'captcha_expired') {
          alertTip = "验证码已过期，请点击刷新";
        } else if (notify_content.message === 'not_found_in_database') {
          alertTip = "帐号或者密码错误";
        } else if (notify_content.message === 'not_found_and_show_captcha') {
          alertTip = "帐号或者密码错误";
        } else if (notify_content.message === 'phone_captcha_fail') {
          alertTip = "手机验证码不通过";
        } else {
          alertTip = notify_content.message;
        }
        return $error_box.html(alertTip).show();
      } else if (notify_content) {
        if ("show" === 'third_party_binding') {
          return $('#third_party_binding-message').html(notify_content.message).addClass('ui message red');
        }
        notify_options.delay = 3000;
        notify_options.template = template;
        notify_options.offset = {
          x: 10,
          y: 30
        };
        notify_options.element = '#messages-container';
        return $.notify(notify_content, notify_options);
      }
    });
  
  }).call(this);
</script>

</div>
<script>
  (function() {
    $(function() {
      var setCookie;
      setCookie = function(name, value) {
        $.cookie(name, value, {
          path: '/',
          expires: 365
        });
      };
      $('#remove-bulletin, #remove-bulletin-dashboard').on('click', function() {
        setCookie('remove_bulletin', "gitee-maintain-1639134196");
        $('#git-bulletin').hide();
      });
      $('#remove-member-bulletin').on('click', function() {
        setCookie('remove_member_bulletin', "gitee_member_bulletin");
        $(this).parent().hide();
      });
      return $('#remove-gift-bulletin').on('click', function() {
        setCookie('remove_gift_bulletin', "gitee-gift-bulletin");
        $(this).parent().hide();
      });
    });
  
  }).call(this);
</script>
<script>
  function closeMessageBanner(pthis, type, val) {
    var json = {}
  
    val = typeof val === 'undefined' ? null : val
    $(pthis).parent().remove()
    if (type === 'out_of_enterprise_member') {
      json = {type: type, data: val}
    } else if (type === 'enterprise_overdue') {
      json = {type: type, data: val}
    }
    $.post('/profile/close_flash_tip', json)
  }
</script>

<div class='site-content'>
<div class='git-project-header'>
<div class='fixed-notice-infos'>
<div class='ui info icon floating message green' id='fetch-ok' style='display: none'>
<div class='content'>
<div class='header status-title'>
<i class='info icon status-icon'></i>
代码拉取完成，页面将自动刷新
</div>
</div>
</div>
<div class='ui info icon floating message error' id='fetch-error' style='display: none'>
<div class='content'>
<div class='header status-title'>
<i class='info icon status-icon'></i>
<span class='error_msg'></span>
</div>
</div>
</div>
</div>
<div class='ui container'>

<div class='git-project-header-details'>
<div class='git-project-header-container'>
<div class='git-project-header-actions'>
<div class='ui tiny modal project-donate-modal' id='project-donate-modal'>
<i class='iconfont icon-close close'></i>
<div class='header'>捐赠</div>
<div class='content'>
未开启捐赠功能，开启捐赠功能需要绑定 OSCHINA 帐号
</div>
<div class='actions'>
<a class='ui blank button cancel'>取消</a>
<a class='ui orange ok button' href='/profile/account_information' target='_blank'>马上绑定</a>
</div>
</div>
<div class='ui small modal wepay-qrcode'>
<i class='iconfont icon-close close'></i>
<div class='header'>
扫描微信二维码支付
<span class='wepay-cash'></span>
</div>
<div class='content weqcode-center'>
<img id='wepay-qrcode' src=''>
</div>
<div class='actions'>
<div class='ui cancel blank button'>取消</div>
<div class='ui ok orange button'>支付完成</div>
</div>
</div>
<div class='ui mini modal' id='confirm-alipay-modal'>
<div class='header'>支付提示</div>
<div class='content'>
将跳转至支付宝完成支付
</div>
<div class='actions'>
<div class='ui approve orange button'>确定</div>
<div class='ui blank cancel button'>取消</div>
</div>
</div>

<span class='ui buttons basic watch-container'>
<div class='ui dropdown button js-project-watch' data-watch-type='watching'>
<input type='hidden' value=''>
<i class='iconfont icon-watch'></i>
<div class='text'>
Watching
</div>
<i class='dropdown icon'></i>
<div class='menu'>
<a data-value="unwatch" class="item" data-remote="true" rel="nofollow" data-method="post" href="/yzqc/DomainRouteMiddleware/unwatch"><i class='iconfont icon-msg-read'></i>
不关注
</a><a data-value="watching" class="item" data-remote="true" rel="nofollow" data-method="post" href="/yzqc/DomainRouteMiddleware/watch"><i class='iconfont icon-msg-read'></i>
关注所有动态
</a><a data-value="releases_only" class="disabled item" data-remote="true" rel="nofollow" data-method="post" href="/yzqc/DomainRouteMiddleware/release_only_watch"><i class='iconfont icon-msg-read'></i>
仅关注版本发行动态
</a><a data-value="ignoring" class="item" data-remote="true" rel="nofollow" data-method="post" href="/yzqc/DomainRouteMiddleware/ignoring_watch"><i class='iconfont icon-msg-read'></i>
关注但不提醒动态
</a></div>
</div>
<style>
  .js-project-watch .text .iconfont {
    display: none; }
  .js-project-watch a, .js-project-watch a:hover {
    color: #000; }
  .js-project-watch .item > .iconfont {
    visibility: hidden;
    margin-left: -10px; }
  .js-project-watch .selected .iconfont {
    visibility: visible; }
  .js-project-watch .menu {
    margin-top: 4px !important; }
</style>
<script>
  $('.js-project-watch').dropdown({
    action: 'select',
    onChange: function(value, text, $selectedItem) {
      var type = value === 'unwatch' ? 'Watch' : 'Watching';
      $(this).children('.text').text(type);
      $(this).dropdown('set selected', value)
    }
  });
</script>

<a class="ui button action-social-count" title="1" href="/yzqc/DomainRouteMiddleware/watchers">1
</a></span>
<span class='basic buttons star-container stared ui'>
<a class="ui button unstar " sa_evt="clickStar" sa_location="其他" sa_url="" sa_repo_id="19817597" data-remote="true" rel="nofollow" data-method="post" href="/yzqc/DomainRouteMiddleware/unstar"><i class='iconfont icon-star-solid'></i>
Starred
</a><a class="ui button star " sa_evt="clickStar" sa_location="其他" sa_url="" sa_repo_id="19817597" data-remote="true" rel="nofollow" data-method="post" href="/yzqc/DomainRouteMiddleware/star"><i class='iconfont icon-star'></i>
Star
</a><a class="ui button action-social-count " title="1" href="/yzqc/DomainRouteMiddleware/stargazers">1
</a></span>
<span class='ui basic buttons fork-container' title=''>
<a id="fork-top-button" class="ui button fork " sa_evt="repoFork" sa_repo_id="19817597" sa_is_self="true" sa_is_member="true" href="#"><i class='iconfont icon-fork'></i>
Fork
</a><a class="ui button action-social-count " title="0" href="/yzqc/DomainRouteMiddleware/members">0
</a></span>
</div>
<h2 class='git-project-title mt-0 mb-0'>
<span class="project-title"><i class="project-icon iconfont icon-project-public" title="这是一个公开仓库"></i> <a title="一醉倾城" class="author" href="/yzqc">一醉倾城</a> / <a title="DomainRouteMiddleware" class="repository" target="" style="padding-bottom: 0px; margin-right: 4px" sa_evt="repoClick" sa_location="其他" sa_url="" sa_repo_id="19817597" href="/yzqc/DomainRouteMiddleware">DomainRouteMiddleware</a></span><span class="project-badges"><a data-confirm="1.你的自荐申请将由我们人工审核，介绍完善、质量高的项目才能被推荐 &lt;br/&gt; 2.编辑可能会根据需要来调整推荐软件的描述信息 &lt;br/&gt; 3.申请提交后，&lt;strong&gt;如一个工作日内未得到推荐，则默认表示被拒&lt;/strong&gt;。" title="自荐" class="git-project-recommend-badge" rel="nofollow" data-method="post" href="/yzqc/DomainRouteMiddleware/recomm_self"><i class='iconfont icon-recommend recommend-icon'></i>
</a><style>
  .gitee-modal {
    width: 500px !important; }
</style>
</span>
<input type="hidden" name="project_title" id="project_title" value="一醉倾城/DomainRouteMiddleware" />
</h2>
</div>
</div>
</div>
<div class='ui small modal long' id='modal-fork-project'>
<i class='icon-close iconfont close'></i>
<div class='header'>
Fork 仓库
</div>
<div class='content'>
<div class='fork-info-content'>
<div class='ui segment fork_project_loader'>
<div class='ui active inverted dimmer'>
<div class='ui text loader'>加载中</div>
</div>
</div>
</div>
</div>
<div class='actions fork-action hide'>
<a class='cancel'>&emsp;取消&emsp;</a>
<div class='ui disabled large button orange ok'>&emsp;确认&emsp;</div>
</div>
</div>
<script>
  var title_import_url = "false";
  var title_post_url = "/yzqc/DomainRouteMiddleware/update_import";
  var title_fork_url = "/yzqc/DomainRouteMiddleware/sync_fork";
  var title_project_path = "DomainRouteMiddleware";
  var title_p_name = "DomainRouteMiddleware";
  var title_p_id= "19817597";
  var title_description = "域名路由中间件可以控制不同的域名，来指向不同的静态资源目录，不需要在域名后面指定具体哪个目录。";
  var title_form_authenticity_token = "pp1Dfw2raCM5+tIYpzRdOXBwS1+wHcR8rYt+5BM33NfnD0GAgJTscdcwIBWmtfq2YN86GCy2JjRCxUg3p6NJTw==";
  var watch_type = "watching";
  
  $('.js-project-watch').dropdown('set selected', watch_type);
  $('.checkbox.sync-wiki').checkbox();
</script>
<script>
  $(function () {
    // SemticUI 校验表单等地方要求直接return 值, 对异步支持非常不友好...
    // 从提交表单处 再用异步校验 ,控制是否提交
    var $modalFork = $('#modal-fork-project');
    var $okBtn = $modalFork.find('.ui.ok.button');
    var $currentTarget = null;
    var isSameProject = false;
  
    $('#fork-top-button, #fork-btm-button').on('click', function (e) {
      e.preventDefault();
      $modalFork.modal('show');
      setTimeout(function () {
        $.ajax({ url: '/yzqc/DomainRouteMiddleware/fork_project_info' }).done(function () {
          // 自定义错误消息模板,  inline : true 每个输入框后面都插入消息提示, 而非集中到一处提醒
          $.fn.form.settings.templates.prompt = function (errors) {
            return $('<div />').addClass('ui error message custom prompt label').html(errors[0]);
          };
          // 表单的内容是异步传输的js动态生成的....
          var $repoForm = $('#modal-fork-project .repo-form');
          $repoForm.form({
            on: 'change',
            inline: true,
            fields: {
              projectName: {
                identifier: 'project-name',
                rules: [
                  {
                    type: 'empty',
                    prompt: "仓库名不能为空"
                  },
                  {
                    type: 'regExp',
                    value: window.giteeRegex.projectName,
                    prompt: "仓库名只允许包含中文、字母、数字或者下划线(_)、中划线(-)、英文句号(.)、加号(+)，必须以字母或数字开头，不能以下划线/中划线结尾，且长度为2~191个字符"
                  },
                  {
                    type: 'maxLength[255]',
                    prompt: "仓库名只允许包含中文、字母、数字或者下划线(_)、中划线(-)、英文句号(.)、加号(+)，必须以字母或数字开头，不能以下划线/中划线结尾，且长度为2~191个字符"
                  }
                ]
              },
              projectPath: {
                identifier: 'project-path',
                rules: [
                  {
                    type: 'empty',
                    prompt: "路径不能为空"
                  },
                  {
                    type: 'regExp',
                    value: window.giteeRegex.projectPath,
                    prompt: "路径只允许包含字母、数字或者下划线(_)、中划线(-)、英文句号(.)，必须以字母开头，且长度为2~191个字符"
                  }
                ]
              }
            }
          });
  
          $modalFork.find('.namespace-img-area.ui.checkbox').checkbox({
            onChecked: function () {
              $currentTarget = $(this).closest('.ui.checkbox');
              // 当前选中的空间
              isSameProject = $currentTarget[0].hasAttribute('data-any-same-projects');
              var conflictProjectName = $currentTarget.data('conflict-project-title');
              var conflictProjectUrl = $currentTarget.data('conflict-project-url');
              var conflictProjectNameSpacePath = $currentTarget.data('conflict-namespace');
              var conflictPathType = $currentTarget.find('.path-type').text();
              // fork目标
              var targetProjectName = $currentTarget.data('target-project-name');
              var targetProjectPath = $currentTarget.data('target-project-path');
              // 命名空间名称(@xxx)
              var conflictNameSpaceName = $currentTarget.find('.path-name').text();
              var $forkTargetNamespace = $('.fork-target-namespace-area');
              // 冲突 显示修改表单
              if (isSameProject) {
                $forkTargetNamespace.addClass('same-name-editing');
                $forkTargetNamespace
                  .find('.conflict-namespace-name')
                  .attr('href', `/${conflictProjectNameSpacePath}`)
                  .text(conflictNameSpaceName);
                $forkTargetNamespace
                  .find('.conflict-path')
                  .attr('href', `${conflictProjectUrl}`)
                  .text(conflictProjectUrl);
                $forkTargetNamespace
                  .find('.prefix-path')
                  .text(`${window.location.origin}/${conflictProjectNameSpacePath}/`);
                $forkTargetNamespace
                  .find('.conflict-path-type')
                  .text(conflictPathType.toLowerCase())
                var $nameInput = $forkTargetNamespace.find('[name="project-name"]');
                var $pathInput = $forkTargetNamespace.find('[name="project-path"]');
                $nameInput.val(targetProjectName);
                $pathInput.val(targetProjectPath);
                // 立即校验一次
                asyncValidateForkRepoForm();
              } else {
                $forkTargetNamespace.removeClass('same-name-editing');
              }
              $okBtn.removeClass('disabled');
            }
          });
        });
      }, 500);
    });
    // 异步校验
    function asyncValidateForkRepoForm (successCallback) {
      var $repoForm = $('#modal-fork-project .repo-form');
      var $forkTargetNamespace = $('.fork-target-namespace-area');
      var name = $forkTargetNamespace.find('[name="project-name"]').val().trim();
      var path = $forkTargetNamespace.find('[name="project-path"]').val().trim();
      var namespace = $currentTarget ? $currentTarget.data('conflict-namespace') : '';
      if (!name || !path) return;
      $okBtn.addClass('loading');
      $.ajax('/projects/check_fork_form', {
        type: 'get',
        data: { project_name: name, project_path: path, target_namespaces: namespace },
        success: function (data) {
          if (data.status == 0) {
            successCallback && successCallback();
          } else if (data.status == -1 && Array.isArray(data.conflict_keys)) {
            data.conflict_keys.includes('name') && $repoForm.form('add prompt', 'project-name', "已存在相同仓库名");
            data.conflict_keys.includes('path') && $repoForm.form('add prompt', 'project-path', "已存在相同路径");
          } else {
            Flash.error("校验失败");
          }
        },
        error: function (err) {
          Flash.error(err.responseJSON.message);
        },
        complete: function () {
          $okBtn.removeClass('loading');
          // 添加提示 弹窗变高后 刷新弹窗位置
          $modalFork.modal('refresh');
        }
      });
    }
    function forkSubmit () {
      $modalFork.modal('hide');
      // 构造一些 input 用于表单提交
      var $form = $('<form></form>');
      var $input = $('<input type="hidden" name="authenticity_token" />');
      var $inputCheck = $('<input type="hidden" name="members" />');
      var $inputCheck2 = $('<input type="hidden" name="namespace_path" />');
      var checkedPath = $('.checkbox.checked > input[name=namespace_path]').val();
      // fork存在冲突, 修改后的表单:
      if (isSameProject) {
        // 获取最新表单数据
        var $forkTargetNamespace = $('.fork-target-namespace-area');
        var name = $forkTargetNamespace.find('[name="project-name"]').val().trim();
        var path = $forkTargetNamespace.find('[name="project-path"]').val().trim();
        var $projectName = $('<input type="hidden" name="name" />');
        var $projectPath = $('<input type="hidden" name="path" />');
        $projectName.val(name);
        $projectPath.val(path);
        $form.append($projectName);
        $form.append($projectPath);
      }
      $form.hide();
      $form.attr('method', 'post');
      $form.attr('action', '/' + checkedPath + '/fork_project/yzqc/DomainRouteMiddleware');
      $input.attr('value', $('meta[name="csrf-token"]').attr('content'));
      $inputCheck.attr('value', $('.checkbox.checked > input[name=members]').val());
      $inputCheck2.attr('value', checkedPath);
      $form.append($input);
      $form.append($inputCheck);
      $form.append($inputCheck2);
      $form.appendTo('body');
      $form.submit();
    }
    $modalFork.modal({
      transition: 'fade',
      closable: true,
      centered: false,
      observeChanges:true,
      onApprove: function () {
        // 存在同名冲突时, 需要修改仓库信息, 再进行校验同名
        // 判断当前选中的空间类型, 用于决定是否需要修改路径仓库名,验证表单
        if (isSameProject) {
          var $repoForm = $('#modal-fork-project .repo-form');
          $repoForm.form('validate form');
          var isRepoInfoValid = $repoForm.form('is valid'); // 前端校验通过
          // 由于是form提交和ajax检测结合..., 防止意外篡改 提交前必定校验一次, 通过后自动submit
          if (isRepoInfoValid) {
            // SemticUI add prompt 自定义验证连续执行太快, 会消失掉重复再出现再消失.
            setTimeout(function () {
              asyncValidateForkRepoForm(function () {
                forkSubmit();
              });
            }, 200);
          } else {
            $repoForm.form('validate form');
          }
        } else {
          // 正常 frok
          forkSubmit();
        }
        return false;
      }
    });
    $modalFork.find('.close-button').on('click', function () {
      $modalFork.modal('hide');
    });
  });
</script>
<style>
  i.loading {
    -webkit-animation: icon-loading 1.2s linear infinite;
    animation: icon-loading 1.2s linear infinite;
  }
  .qrcode_cs {
    float: left;
  }
  .check-sync-wiki {
    float: left;
    height: 28px;
    line-height: 28px;
  }
  .sync-wiki-warn {
    color: #e28560;
  }
</style>

<div class='git-project-nav'>
<div class='ui container'>
<div class='ui secondary pointing menu'>
<a class="item active" href="/yzqc/DomainRouteMiddleware"><i class='iconfont icon-code'></i>
代码
</a><a class="item " href="/yzqc/DomainRouteMiddleware/issues"><i class='iconfont icon-task'></i>
Issues
<span class='ui mini circular label'>
0
</span>
</a><a class="item " href="/yzqc/DomainRouteMiddleware/pulls"><i class='iconfont icon-pull-request'></i>
Pull Requests
<span class='ui mini circular label'>
0
</span>
</a><a class="item " href="/yzqc/DomainRouteMiddleware/wikis"><i class='iconfont icon-wiki'></i>
Wiki
</a><a class="item  " href="/yzqc/DomainRouteMiddleware/repository/stats/master"><i class='iconfont icon-statistics'></i>
统计
</a><div class='item project-devops-item'>
<div class='ui pointing top right dropdown project-devops-dropdown'>
<div class='text'>
<i class='iconfont icon-devops'></i>
DevOps
</div>
<i class='dropdown icon'></i>
<div class='menu' style='display:none'>
<a class="item" href="/yzqc/DomainRouteMiddleware/gitee_go"><img src="https://assets.gitee.com/assets/giteego-7ec42270742374f05850d0d3ad09e303.png" alt="Giteego" />
<div class='item-title'>
Gitee Go
</div>
</a><a class="item" href="/yzqc/DomainRouteMiddleware/artifact_repositories"><img src="https://assets.gitee.com/assets/artifacts-eae00b503105733ce5f171de96fbb927.svg" alt="Artifacts" />
<div class='item-title'>
制品库管理
</div>
</a><a class="item" target="_blank" href="https://gitee.com/help/articles/4285"><img src="https://assets.gitee.com/assets/baidu_efficiency_cloud-81a98c2eb67fac83b1453ca3d2feb326.svg" alt="Baidu efficiency cloud" />
<div class='item-title'>
百度效率云
</div>
</a><a class="item" target="_blank" href="https://gitee.com/help/articles/4318"><img src="https://assets.gitee.com/assets/cloudbase-1197b95ea3398aff1df7fe17c65a6d42.png?20200925" alt="Cloudbase" />
<div class='item-title'>
腾讯云托管
</div>
</a><a class="item" target="_blank" href="https://gitee.com/help/articles/4330"><img src="https://assets.gitee.com/assets/cloud_serverless-686cf926ced5d6d2f1d6e606d270b81e.png" alt="Cloud serverless" />
<div class='item-title'>
腾讯云 Serverless
</div>
</a><a class="item" target="_blank" href="https://gitee.com/help/articles/4193"><img src="https://assets.gitee.com/assets/jenkins_for_gitee-554ec65c490d0f1f18de632c48acc4e7.png" alt="Jenkins for gitee" />
<div class='item-title'>
Jenkins for Gitee
</div>
</a></div>
</div>
</div>
<div class='item'>
<div class='ui pointing top right dropdown git-project-service'>
<div>
<i class='iconfont icon-service'></i>
服务
<i class='dropdown icon'></i>
</div>
<div class='menu' style='display:none'>
<a class="item" href="/yzqc/DomainRouteMiddleware/pages"><img src="/static/images/logo-en.svg" alt="Logo en" />
<div class='item-title'>
Gitee Pages
</div>
</a><a class="item" href="/yzqc/DomainRouteMiddleware/javadoc"><img src="https://assets.gitee.com/assets/maven-bd58aee84f266d64d4b8ce5b006a9fcf.png" alt="Maven" />
<div class='item-title'>
JavaDoc
</div>
</a><a class="item" href="/yzqc/DomainRouteMiddleware/phpdoc"><img src="https://assets.gitee.com/assets/phpdoc-a99f87c2feaa2fd99e5065377a39487e.png" alt="Phpdoc" />
<div class='item-title'>
PHPDoc
</div>
</a><a class="item" href="/yzqc/DomainRouteMiddleware/quality_analyses?platform=sonar_qube"><img src="https://assets.gitee.com/assets/sonar_mini-5e1b54bb9f6c951d97fb778ef623afea.png" alt="Sonar mini" />
<div class='item-title'>
质量分析
</div>
</a><a class="item" href="/yzqc/DomainRouteMiddleware/quality_analyses?platform=codesafe"><img width="100%" src="https://assets.gitee.com/assets/codesafe_mini-accbe1e555e9864c552620240d10e4de.png" alt="Codesafe mini" />
<div class='item-title'>
奇安信代码卫士
</div>
</a><a class="item" href="/yzqc/DomainRouteMiddleware/gitee_scans"><img src="https://assets.gitee.com/assets/giteescan-cd9ab4076bd751faf7e30888eb10f782.png" alt="Giteescan" />
<div class='item-title'>Gitee Scan</div>
</a><a class="item" href="/yzqc/DomainRouteMiddleware/codecheck/report?branch=master"><img src="https://assets.gitee.com/assets/CodeCheck-70a10cf889c51df6f00bf159c8e12374.svg" alt="Codecheck" />
<div class='item-title'>CodeCheck</div>
</a><a class="item" href="/yzqc/DomainRouteMiddleware/fosseye_scans"><img src="https://assets.gitee.com/assets/lic-de91a87a4f8dad44d993b27a69d58d5e.png" alt="Lic" />
<div class='item-title'>
许可证合规分析
</div>
</a><button class='ui orange basic button quit-button' id='quiting-button'>
我知道了，不再自动展开
</button>
</div>
</div>
</div>
<a class="item d-flex d-flex-center " href="/yzqc/DomainRouteMiddleware/settings"><i class='iconfont icon-settings'></i>
<div class='text ml-05 setting-text'>管理</div>
</a></div>
</div>
</div>
<script>
  $('.git-project-nav .ui.dropdown').dropdown({ action: 'nothing' });
  var gitee_reward_config = JSON.parse(localStorage.getItem('gitee_reward_config') || null) || false
  var $settingText = $('.setting-text')
  // 如果没有访问过 
  if(!gitee_reward_config) $settingText.addClass('red-dot')
</script>
<style>
  .git-project-nav i.checkmark.icon {
    color: green;
  }
  #quiting-button {
    display: none;
  }
  
  .git-project-nav .dropdown .menu.hidden:after {
    visibility: hidden !important;
  }
</style>
<script>
  isSignIn = true
  isClickGuide = true
  $('#git-versions.dropdown').dropdown();
  $.ajax({
    url:"/yzqc/DomainRouteMiddleware/access/add_access_log",
    type:"GET"
  });
  $('#quiting-button').on('click',function() {
    $('.git-project-service').click();
    if (isSignIn) {
      $.post("/projects/set_service_guide")
    }
    $.cookie("Serve_State", true, { expires: 3650, path: '/'})
    $('#quiting-button').hide();
  });
  if (!(isClickGuide || $.cookie("Serve_State") == 'true')) {
    $('.git-project-service').click()
    $('#quiting-button').show()
  }
</script>

</div>
<div class='ui container'>

<div class='git-project-content-wrapper'>
<div class='ui grid' id='project-wrapper'>
<div class='sixteen wide column'>
<div class='git-project-content' id='git-project-content'>
<div class='row'>
<div class='git-project-desc-wrapper'>
<script>
  if (false) {
    gon.project_new_blob_path = "/yzqc/DomainRouteMiddleware/new/master/README.md"
    bindShowModal({
      el: $('.no-license .project-license__create'),
      complete: function(data, modal) {
        if (!data.haveNoChoice && !data.data) {
          Flash.show('请选择一项开源许可证')
        } else {
          location.href = gon.project_new_blob_path + '?license=' + data.data
        }
      },
      skip: function () {
        location.href = gon.project_new_blob_path + '?license'
      }
    });
  }
  
  $('i.help.circle.icon').popup({
    popup: '.no-license .ui.popup',
    position: 'right center'
  });
  
  $('#remove-no-license-message').on('click', function() {
    $.cookie("skip_repo_no_license_message_19817597", 'hide', { expires: 365 });
    $('#user-no-license-message').hide();
    return;
  });
</script>
</div>

</div>
<div class='git-project-bread' id='git-project-bread'>
<div class='ui horizontal list mr-1'>
<div class='item git-project-branch-item'>
<input type="hidden" name="path" id="path" value="README.md" />
<div class='ui top left pointing dropdown gradient button dropdown-has-tabs' id='git-project-branch'>
<input type="hidden" name="ref" id="ref" value="master" />
<div class='default text'>
master
</div>
<i class='dropdown icon'></i>
<div class='menu'>
<div class='ui left icon search input'>
<i class='iconfont icon-search'></i>
<input class='search-branch' placeholder='搜索分支' type='text'>
</div>
<div class='tab-menu'>
<div class='tab-menu-action' data-tab='branches'>
<a class="ui link button" href="/yzqc/DomainRouteMiddleware/branches">管理</a>
</div>
<div class='tab-menu-action' data-tab='tags'>
<a class="ui link button" href="/yzqc/DomainRouteMiddleware/tags">管理</a>
</div>
<div class='tab-menu-item' data-placeholder='搜索分支' data-tab='branches'>
分支 (1)
</div>
</div>
<div class='tab scrolling menu' data-tab='branches' id='branches_panel'>
<div data-value="master" class="item"><span>master</span></div>
</div>
</div>
</div>
<style>
  .iconfont.icon-shieldlock {
    color: #8c92a4;
  }
</style>
<script>
  var $branchesDropdown = $('#branches_panel');
  var $searchNameInput = $('.search-branch');
  var concurrentRequestLock = false;
  var filterXSS = window.filterXSS;
  $branchesDropdown.scroll(function() {
    var branchesPanel = document.getElementById('branches_panel');
    var numOfBranches = $branchesDropdown.children().length;
    var pageToken = $branchesDropdown.children().last().text().trim();
    if (branchesPanel.clientHeight + branchesPanel.scrollTop + 37 > branchesPanel.scrollHeight && numOfBranches < 1) {
      loadData({ page_token: pageToken });
    }
  });
  
  $searchNameInput.on('input', window.globalUtils.debouce(function (e) {
    var $currentTab = $('.tab-menu-action.active');
    var numOfBranches = $branchesDropdown.children().length;
    if($currentTab.data('tab') === 'branches' && numOfBranches < 1) {
    var searchWord = $searchNameInput.val().trim();
      if (searchWord !== "") {
        loadData({ search: searchWord });
      } else {
        loadData({});
      }
    }
  }, 500));
  
  function loadData(data) {
    if (concurrentRequestLock) { return; }
      concurrentRequestLock = true;
      $.ajax({
        url: "/yzqc/DomainRouteMiddleware/branches/load_more",
        type: 'GET',
        data: data,
        dataType: 'json',
        success: function (branches) {
          var html = '';
          var protectRule = '';
          if (data.search || !data.page_token) {
            $branchesDropdown.empty();
          }
          branches.forEach(function (branch) {
            var branchName = filterXSS(branch.name);
            if(branch.branch_type.value === 1) {
              var rule = filterXSS(branch.protection_rule.wildcard);
              protectRule = `<i
                 class="iconfont icon-shieldlock protected-branch-popup"
                 data-title="受保护分支"
                 data-content='保护规则： ${rule}'
                >
                </i>`
            }
            html += `<div data-value='${branchName}' class="item">
                      <span>${branchName}</span> ${protectRule}
                     </div>`
          });
          $branchesDropdown.append(html);
          $('.protected-branch-popup').popup()
        },
        complete: function () {
          concurrentRequestLock = false;
        }
    });
  }
</script>

<script>
  $(function () {
    Gitee.initTabsInDropdown($('#git-project-branch').dropdown({
      fullTextSearch: true,
      selectOnKeydown: true,
      action: function (text,value,el) {
        var oItemOrInitObject = el[0] || el
        var isNotSelect = oItemOrInitObject.dataset.tab && oItemOrInitObject.dataset.tab === 'branches'
        if(isNotSelect){
          console.warn("You didn't choose a branch")
          return
        } 
        var path = $('#path').val();
        var href = ['/yzqc/DomainRouteMiddleware/tree', encodeURIComponent(value), path].join('/');
        window.location.href = href;
        return true
      },
      onNoResults: function (searchTerm) {
        //未找到结果
        return true
      },
    }));
    $('.protected-branch-popup').popup()
  })
</script>

</div>
</div>
<div class='git-project-right-actions pull-right'>
<div class='ui orange button' id='btn-dl-or-clone'>
克隆/下载
<i class='dropdown icon'></i>
</div>
<div class='git-project-download-panel for-project ui bottom right popup'>
<div class='ui small secondary pointing menu'>
<a class='item active' data-text='' data-type='http' data-url='https://gitee.com/yzqc/DomainRouteMiddleware.git'>HTTPS</a>
<a class='item' data-text='' data-type='ssh' data-url='git@gitee.com:yzqc/DomainRouteMiddleware.git'>SSH</a>
<a class='item' data-text="该仓库未启用SVN访问，请仓库管理员前往【&lt;a target='_blank' href=/yzqc/DomainRouteMiddleware/settings&gt;仓库设置&lt;/a&gt;】开启。" data-type='svn' data-url=''>SVN</a>
<a class='item' data-text="该仓库未启用SVN访问，请仓库管理员前往【&lt;a target='_blank' href=/yzqc/DomainRouteMiddleware/settings&gt;仓库设置&lt;/a&gt;】开启。" data-type='svn_ssh' data-url=''>SVN+SSH</a>
</div>
<div class='ui fluid right labeled small input download-url-panel'>
<input type="text" name="project_clone_url" id="project_clone_url" value="https://gitee.com/yzqc/DomainRouteMiddleware.git" onclick="focus();select()" readonly="readonly" />
<div class='ui basic label'>
<div class='ui small basic orange button' data-clipboard-target='#project_clone_url' id='btn-copy-clone-url'>
复制
</div>
</div>
</div>
<div class='ui fluid right labeled warning-text forbid-warning-text'>

</div>
<hr>
<a class="ui fluid tiny download link button" sa_evt="repoDownload" sa_repo_id="19817597" sa_is_self="true" sa_is_member="true" href="/yzqc/DomainRouteMiddleware/repository/archive/master.zip"><i class='icon download'></i>
下载ZIP
</a></div>
<script>
  (function() {
    var $btnClone, $btnCopy, $input, $panel;
  
    $btnClone = $('#btn-dl-or-clone');
  
    $panel = $('.git-project-download-panel');
  
    $input = $('#project_clone_url');
  
    $btnCopy = $('#btn-copy-clone-url');
  
    $btnClone.popup({
      on: 'click',
      hoverable: true,
      position: 'bottom center'
    });
  
    $panel.find('.menu > .item').on('click', function(e) {
      var $item, dataUrl;
      $item = $(this).addClass('active');
      $item.siblings().removeClass('active');
      dataUrl = $item.attr('data-url');
      if (dataUrl) {
        $panel.find('.download-url-panel').show();
        $input.val(dataUrl);
        $panel.find('.forbid-warning-text').html('');
      } else {
        $panel.find('.download-url-panel').hide();
        $panel.find('.forbid-warning-text').html($item.attr('data-text') || '');
      }
      return $.cookie('remote_way', $item.attr('data-type'), {
        expires: 365,
        path: '/'
      });
    }).filter('[data-type="' + ($.cookie('remote_way') || 'http') + '"]').trigger('click');
  
    new Clipboard($btnCopy[0]).on('success', function() {
      $btnCopy.popup({
        content: '已复制',
        position: 'right center',
        onHidden: function() {
          return $btnCopy.popup('destroy');
        }
      });
      return $btnCopy.popup('show');
    });
  
  }).call(this);
</script>

</div>
<div class='d-inline pull-right' id='git-project-root-actions'>
<script>
  $('.disabled-upload-readonly').popup({
    content: "只读目录不允许上传文件",
    className: {
      popup: 'ui popup',
    },
    position: 'bottom center',
  })
  $('.disabled-create-folder').popup({
    content: "只读目录不允许创建目录",
    className: {
      popup: 'ui popup',
    },
    position: 'bottom center',
  })
  $('.disabled-create-file').popup({
    content: "只读目录不允许创建文件",
    className: {
      popup: 'ui popup',
    },
    position: 'bottom center',
  })
  $('.disabled-create-submodule').popup({
    content: "只读目录不允许创建子模块",
    className: {
      popup: 'ui popup',
    },
    position: 'bottom center',
  })
  $('.disabled-upload-readonly, .disabled-create-folder, .disabled-create-file, .disabled-create-submodule').click(function() {
    return false
  })
</script>
<style>
  .disabled-upload-readonly, .disabled-create-file, .disabled-create-folder, .disabled-create-submodule {
    background-color: #dcddde !important;
    color: rgba(0, 0, 0, 0.4) !important;
    opacity: 0.3 !important;
    background-image: none !important;
    -webkit-box-shadow: none !important;
            box-shadow: none !important; }
</style>


</div>
<div class='breadcrumb_path path-breadcrumb-contrainer' id='git-project-breadcrumb'>
<div class='ui breadcrumb path project-path-breadcrumb' id='path-breadcrumb'>
<a data-direction="back" class="section repo-name" style="font-weight: bold" href="/yzqc/DomainRouteMiddleware/tree/master">DomainRouteMiddleware
</a><div class='divider'>
/
</div>
<strong>
README.md
</strong>
<i class='iconfont icon-clone' data-clipboard-text='README.md' id='btn-copy-file-path'></i>
</div>
<style>
  #btn-copy-file-path {
    vertical-align: middle;
    cursor: pointer;
  }
</style>
<script>
  $btnCopy = $('#btn-copy-file-path')
  $btnCopy.popup({
    content: '复制路径'
  })
  
  if ($btnCopy[0]) {
    new Clipboard($btnCopy[0]).on('success', function() {
      $btnCopy.popup('destroy').popup({
        content: '已复制',
        on: 'manual'
      }).popup('show');
      setTimeout(function () {
        $btnCopy.popup('destroy').popup({
          content: '复制路径'
        });
      }, 2000)
    });
  }
</script>


</div>
<div class='ui horizontal list repo-action-list branches-tags' style='display: none;'>
<div class='item'>
<a class="ui blank button" href="/yzqc/DomainRouteMiddleware/branches"><i class='iconfont icon-branches'></i>
分支 1
</a></div>
<div class='item mr-3'>
<a class="ui blank button" href="/yzqc/DomainRouteMiddleware/tags"><i class='iconfont icon-tag'></i>
标签 0
</a></div>
</div>
</div>
<script>
  if(window.gon.locale == 'en')
    $('.branches-tags').css('margin-top', '12px')
</script>

<style>
  .ui.dropdown .menu > .header {
    text-transform: none; }
</style>
<script>
  $(function () {
    var $tip = $('#apk-download-tip');
    if (!$tip.length) {
      return;
    }
    $tip.find('.btn-close').on('click', function () {
      $tip.hide();
    });
  });
  (function(){
    function pathAutoRender() {
      var $parent = $('#git-project-bread'),
          $child = $('#git-project-bread').children('.ui.horizontal.list'),
          mainWidth = 0;
      $child.each(function (i,item) {
        mainWidth += $(item).width()
      });
      $('.breadcrumb.path.fork-path').remove();
      if (mainWidth > 995) {
        $('#path-breadcrumb').hide();
        $parent.append('<div class="ui breadcrumb path fork-path">' + $('#path-breadcrumb').html() + '<div/>')
      } else {
        $('#path-breadcrumb').show();
      }
    }
    window.pathAutoRender = pathAutoRender;
    pathAutoRender();
  })();
</script>

<div class='row column tree-holder' id='tree-holder'>
<div class='tree-content-holder' id='tree-content-holder'>
<div class='file_holder'>
<div class='file_title'>
<div class='blob-header-title'>
<div class='blob-description'>
<i class="iconfont icon-file"></i>
<span class='file_name' title='README.md'>
README.md
</span>
<small>1.76 KB</small>
</div>
<div class='options'><div class='ui mini buttons basic'>

<textarea name="blob_raw" id="blob_raw" style="display:none;">
# DomainRouteMiddleware&#x000A;&#x000A;域名路由中间件可以控制不同的域名，来指向不同的静态资源目录，不需要在域名后面指定具体哪个目录。&#x000A;启用缓存机制，同一个域名的路由解析只有一次，之后都走缓存，所以不存在性能问题，解析速度非常快。&#x000A;在保证缓存的前提下，同时提供清除缓存与热重载的功能，保证路由规则改动之后不需要重启服务即可重载路由配置。&#x000A;&#x000A;使用说明&#x000A;&#x000A;一、hosts绑定以下域名&#x000A;&#x000A;```&#x000A;127.0.0.1 domain.com&#x000A;127.0.0.1 www.domain.com&#x000A;127.0.0.1 admin.domain.com&#x000A;127.0.0.1 wap.domain.com&#x000A;127.0.0.1 tpl-a.domain.com&#x000A;127.0.0.1 tpl-b.domain.com&#x000A;127.0.0.1 tpl-c.domain.com&#x000A;```&#x000A;&#x000A;&#x000A;&#x000A;二、启动demo&#x000A;&#x000A;&#x000A;三、分别访问hosts绑定的域名，可以看到，不同域名指向不同的静态资源目录&#x000A;    访问时，需要加端口&#x000A;    如启动demo的访问地址为：https://localhost:7005，则域名访问的时候，地址为：&#x000A;    &#x000A;```&#x000A;    https://www.domain.com:7005&#x000A;    https://admin.domain.com:7005&#x000A;    https://wap.domain.com:7005&#x000A;    https://tpl-a.domain.com:7005&#x000A;    https://tpl-b.domain.com:7005&#x000A;    https://tpl-c.domain.com:7005&#x000A;```&#x000A;     **ps:加端口只是调试环境使用，若在线上使用80或者443端口，则无需加端口号** &#x000A;&#x000A;&#x000A;四、访问“/api/home/ReloadRoute”控制器可以热重载修改后的路由规则（该方法同时会清除路由缓存）&#x000A;&#x000A;&#x000A;五、访问“/api/home/ClearRouteCache”控制器可以清理路由缓存&#x000A;&#x000A;&#x000A;六、启动中间件：app.UseMiddleware&lt;DomainRouteMiddleware.ExportRoute&gt;(); &#x000A;    需要在 app.UseFileServer(new FileServerOptions(){FileProvider = new PhysicalFileProvider($&quot;{System.Environment.CurrentDirectory}\\&quot;)}); &#x000A;   之前调用，详情见demo&#x000A;&#x000A;</textarea>
<a class="ui button" id="copy-text" href="#">一键复制</a>
<a class="ui button edit-blob" title="" href="/yzqc/DomainRouteMiddleware/edit/master/README.md">编辑</a>
<a class="ui button web-ide" target="_blank" href="/-/ide/project/yzqc/DomainRouteMiddleware/edit/master/-/README.md">Web IDE</a>
<a class="ui button edit-raw" target="_blank" href="/yzqc/DomainRouteMiddleware/raw/master/README.md">原始数据</a>
<a class="ui button edit-blame" href="/yzqc/DomainRouteMiddleware/blame/master/README.md">按行查看</a>
<a class="ui button edit-history" href="/yzqc/DomainRouteMiddleware/commits/master/README.md">历史</a>
</div>
<div class='ui mini basic icon-actions'>
<a title="删除文件 master/README.md" data-confirm="确定要删除吗？" rel="nofollow" data-method="delete" href="/yzqc/DomainRouteMiddleware/delete/blob/master/README.md"><i class='iconfont icon-delete'></i>
</a></div>
<script>
  "use strict";
  try {
    if((gon.wait_fork!=undefined && gon.wait_fork==true) || (gon.wait_fetch!=undefined && gon.wait_fetch==true)){
      $('.edit-blob').popup({content:"当前仓库正在后台处理中,暂时无法编辑", on: 'hover', delay: { show: 200, hide: 200 }});
      $('.edit-blob').click(function(e){
        e.preventDefault();
      })
    }
  
    var setUrl = function() {
      var params = window.location.search
      if (params==undefined || $.trim(params).length==0) return;
      $('span.options').children('.basic').find('a').each(function(index,ele){
        var origin_href = $(ele).attr('href');
        if (origin_href!="#" && origin_href.indexOf('?') == -1){
          $(ele).attr('href',origin_href+params);
        }
      });
    }
  
    setUrl();
  
    var clipboard = null,
        $btncopy  = $("#copy-text");
  
    clipboard = new Clipboard("#copy-text", {
      text: function(trigger) {
        return $("#blob_raw").val();
      }
    })
  
    clipboard.on('success', function(e) {
      $btncopy.popup('hide');
      $btncopy.popup('destroy');
      $btncopy.popup({content: '已复制', position: 'bottom center'});
      $btncopy.popup('show');
    })
  
    clipboard.on('error', function(e) {
      var giteeModal = new GiteeModalHelper({okText: '确定'});
      giteeModal.alert("一键复制", '复制失败，请手动复制');
    })
  
    $(function() {
      $btncopy.popup({
        content: '点击复制',
        position: 'bottom center'
      })
    })
  
  } catch (error) {
    console.log('blob/action error:' + error);
  }
  
  $('.disabled-edit-readonly').popup({
    content: "只读文件不可编辑",
    className: {
      popup: 'ui popup',
    },
    position: 'bottom center',
  })
  $('.disabled-edit-readonly, .disabled-edit-status').click(function() {
    return false
  })
  $('.has_tooltip').popup({
    position: 'top center'
  });
</script>
<style>
  .disabled-edit-readonly, .disabled-edit-status {
    background-color: #dcddde !important;
    color: rgba(0, 0, 0, 0.4) !important;
    opacity: 0.3 !important;
    background-image: none !important;
    -webkit-box-shadow: none !important;
            box-shadow: none !important;
    cursor: default !important; }
</style>
</div>
</div>
<div class='contributor-description'><span class='recent-commit' style='margin-top: 0.7rem'>
<a class="commit-author-link  js-popover-card " data-username="yzqc" href="/yzqc">一醉倾城</a>
<span>提交于</span>
<span class='timeago commit-date' title='2021-12-15 07:00:35 +0000'>
2021-12-15 07:00
</span>
.
<a href="/yzqc/DomainRouteMiddleware/commit/2a5843f832c92abc73160f37572bc1889512dda4">update README.md.</a>
</span>
</div>
</div>
<div class='clearfix'></div>
<div class='file_catalog'>
<div class='toggle'>
<i class='icon angle left'></i>
</div>
<div class='scroll-container'>
<div class='container'>
<div class='skeleton'>
<div class='line line1'></div>
<div class='line line2'></div>
<div class='line line3'></div>
<div class='line line1'></div>
<div class='line line2'></div>
<div class='line line3'></div>
</div>
</div>
</div>
</div>
<div class='file_content markdown-body'>
<h1>&#x000A;<a id="user-content-domainroutemiddleware" class="anchor" href="#domainroutemiddleware"></a>DomainRouteMiddleware</h1>&#x000A;<p>域名路由中间件可以控制不同的域名，来指向不同的静态资源目录，不需要在域名后面指定具体哪个目录。&#x000A;启用缓存机制，同一个域名的路由解析只有一次，之后都走缓存，所以不存在性能问题，解析速度非常快。&#x000A;在保证缓存的前提下，同时提供清除缓存与热重载的功能，保证路由规则改动之后不需要重启服务即可重载路由配置。</p>&#x000A;<p>使用说明</p>&#x000A;<p>一、hosts绑定以下域名</p>&#x000A;<div class="white"><div class="highlight markdown-code-block">&#x000A;<pre><span id="LC1" class="line">127.0.0.1 domain.com</span>&#x000A;<span id="LC2" class="line">127.0.0.1 www.domain.com</span>&#x000A;<span id="LC3" class="line">127.0.0.1 admin.domain.com</span>&#x000A;<span id="LC4" class="line">127.0.0.1 wap.domain.com</span>&#x000A;<span id="LC5" class="line">127.0.0.1 tpl-a.domain.com</span>&#x000A;<span id="LC6" class="line">127.0.0.1 tpl-b.domain.com</span>&#x000A;<span id="LC7" class="line">127.0.0.1 tpl-c.domain.com</span></pre>&#x000A;<div class="markdown-code-block-copy-btn"></div>&#x000A;</div></div>&#x000A;<p>二、启动demo</p>&#x000A;<p>三、分别访问hosts绑定的域名，可以看到，不同域名指向不同的静态资源目录&#x000A;访问时，需要加端口&#x000A;如启动demo的访问地址为：<a href="https://localhost:7005%EF%BC%8C%E5%88%99%E5%9F%9F%E5%90%8D%E8%AE%BF%E9%97%AE%E7%9A%84%E6%97%B6%E5%80%99%EF%BC%8C%E5%9C%B0%E5%9D%80%E4%B8%BA%EF%BC%9A" rel="nofollow">https://localhost:7005，则域名访问的时候，地址为：</a></p>&#x000A;<div class="white"><div class="highlight markdown-code-block">&#x000A;<pre><span id="LC1" class="line">    https://www.domain.com:7005</span>&#x000A;<span id="LC2" class="line">    https://admin.domain.com:7005</span>&#x000A;<span id="LC3" class="line">    https://wap.domain.com:7005</span>&#x000A;<span id="LC4" class="line">    https://tpl-a.domain.com:7005</span>&#x000A;<span id="LC5" class="line">    https://tpl-b.domain.com:7005</span>&#x000A;<span id="LC6" class="line">    https://tpl-c.domain.com:7005</span></pre>&#x000A;<div class="markdown-code-block-copy-btn"></div>&#x000A;</div></div>&#x000A;<div class="white"><div class="highlight markdown-code-block">&#x000A;<pre><span id="LC1" class="line"> **ps:加端口只是调试环境使用，若在线上使用80或者443端口，则无需加端口号** </span></pre>&#x000A;<div class="markdown-code-block-copy-btn"></div>&#x000A;</div></div>&#x000A;<p>四、访问“/api/home/ReloadRoute”控制器可以热重载修改后的路由规则（该方法同时会清除路由缓存）</p>&#x000A;<p>五、访问“/api/home/ClearRouteCache”控制器可以清理路由缓存</p>&#x000A;<p>六、启动中间件：app.UseMiddleware&lt;DomainRouteMiddleware.ExportRoute&gt;();&#x000A;需要在 app.UseFileServer(new FileServerOptions(){FileProvider = new PhysicalFileProvider($"{System.Environment.CurrentDirectory}\")});&#x000A;之前调用，详情见demo</p></div>
<script>
  window.Gitee.initReadmeCatalog();
  toMathMlCode('','markdown-body');
  $('.file_content a, .catalog-li a.anchor').click(function () {
    var anchor = $(this).attr('href')
    window.location.hash = anchor
  })
</script>

</div>
</div>
<div class='tree_progress'></div>
<div class='ui small modal' id='modal-linejump'>
<div class='ui custom form content'>
<div class='field'>
<div class='ui right action input'>
<input placeholder='跳转至某一行...' type='number'>
<div class='ui orange button'>
跳转
</div>
</div>
</div>
</div>
</div>


<div class='row column inner-comment' id='blob-comment'>
<input type="hidden" name="comment_path" id="comment_path" value="README.md" />
<div class='tree-comments'>
<h3 id='tree_comm_title'>
评论
(
<span class='comments-count'>
0
</span>
)
</h3>
<div class='ui threaded comments middle aligned' id='notes-list'></div>
<input type="hidden" name="ajax_add_note_id" id="ajax_add_note_id" />
<div class='text-center'>
<div class='tip-loading' style='display: none'>
<div class='ui active mini inline loader'></div>
正在加载...
</div>
</div>
</div>
<script>
  "use strict";
  $(function(){
    var page = 1
    var commentsCount = 0
    var $container = $('.tree-comments')
    var $comments = $container.find('.ui.comments')
    var $tipLoading = $container.find('.tip-loading')
    var $btnLoad = $container.find('.btn-load-more')
    var noteAnchor = new Gitee.NoteAnchor({ defaultAnchor: '#tree_comm_title' })
  
    if (commentsCount < 1) {
      return;
    }
  
    var path;
    if ($('#comment_path').val() === '') {
      path = '/';
    } else {
      path = $('#comment_path').val();
    }
  
    function loadComments () {
      $btnLoad.hide();
      $tipLoading.show();
      $.ajax({
        url: '/yzqc/DomainRouteMiddleware/comment_list',
        data: {
          page: page,
          path: path
        },
        success: function(data) {
          var err;
          try {
            $tipLoading.hide();
            $btnLoad.show();
            if (data.status !== 0) {
              $btnLoad.text('无更多评论')
              return $btnLoad.prop('disabled', true).addClass('disabled');
            } else {
              TreeComment.CommentListHandler(data);
              page += 1;
              if (data.comments_count < 10) {
                $('#ajax_add_note_id').val('');
                $btnLoad.text('无更多评论')
                $btnLoad.prop('disabled', true).addClass('disabled');
              }
              // osctree can not load script
              $comments.find('.timeago').timeago();
              $comments.find('.commenter-role-label').popup();
              noteAnchor.locate();
              toMathMlCode('', 'comments');
              return $('.markdown-body pre code').each(function(i, block) {
                return hljs.highlightBlock(block);
              });
            }
          } catch (error) {
            err = error;
            return console.log('loadComments error:' + err);
          }
        }
      });
    };
  
  
    function checkLoad () {
      var listTop, top;
      top = $(window).scrollTop();
      listTop = $container.offset().top;
      if (listTop >= top && listTop < top + $(window).height()) {
        $(window).off('scroll', checkLoad);
        return loadComments();
      }
    };
  
    $btnLoad.on('click', loadComments);
    loadComments()
  })
</script>

</div>
<div class='inner-comment-box' id='comment-box'>
<div class='tree-comment-form' data-username='yzqc' id='tree-comment-box'>
<img class="ui avatar image js-popover-card" avatar="一醉倾城-yzqc" />
<div class='ui form'>
<input type="hidden" name="comment_url" id="comment_url" value="/yzqc/DomainRouteMiddleware/comment" />
<div class='field'>
<textarea class='md-input' id='editor_comment' placeholder='在此输入你想说的话，如果是问题或者建议，请添加 issue。（评论支持 Markdown 格式）'></textarea>
</div>
<div class='ui checkbox js-check-star' style='display:none'>
<input name='comments_with_star' type='checkbox'>
<label>同时点个赞（Star）</label>
</div>

<div class='ui field aligned except-editor-textarea mt-2'>
<div class='ui warning message' id='comment_error_message' style='display: block;'>
评论内容请保持在200字以内，项目相关的技术问题、缺陷报告、建议等信息请通过<a href="/yzqc/DomainRouteMiddleware/issues/new"> Issue </a>发布
</div>
<div class='ui orange button js-comment-button disabled' id='only_comment'>
评论
</div>
<span class='text-muted' id='comment_characters_message'>0</span>
<span class='text-muted'>/</span>
<span class='text-muted'>
200
</span>
<div class='ui blank button js-close-discussion-note-form' id='comment_cancel_btn'>
取消
</div>
</div>
</div>
</div>
<script>
  "use strict";
  TreeComment.init();
  gon.comment_limit = "评论不可超过 200 字"
</script>

</div>

<div class='complaint'>
<div class='ui modal small form' id='landing-comments-complaint-modal'>
<i class='iconfont icon-close close'></i>
<div class='header'>
举报
</div>
<div class='content'>
<div class='appeal-success-tip hide'>
<i class='iconfont icon-ic_msg_success'></i>
<div class='appeal-success-text'>
举报成功
</div>
<span>
我们将于2个工作日内通过站内信反馈结果给你！
</span>
</div>
<div class='appeal-tip'>
请认真填写举报原因，尽可能描述详细。
</div>
<div class='ui form appeal-form'>
<div class='inline field'>
<label class='left-part appeal-type-wrap'>
举报类型
</label>
<div class='ui dropdown selection' id='appeal-comments-types'>
<div class='text default'>
请选择举报类型
</div>
<i class='dropdown icon'></i>
<div class='menu'></div>
</div>
</div>
<div class='inline field'>
<label class='left-part'>
举报原因
</label>
<textarea class='appeal-reason' id='appeal-comment-reason' name='msg' placeholder='请说明举报原因' rows='3'></textarea>
</div>
<div class='ui message callback-msg hide'></div>
<div class='ui small error text message exceeded-size-tip'></div>
</div>
</div>
<div class='actions'>
<div class='ui button blank cancel'>
取消
</div>
<div class='ui orange icon button disabled ok' id='complaint-comment-confirm'>
发送
</div>
</div>
</div>
<script>
  var $complaintCommentsModal = $('#landing-comments-complaint-modal'),
      $complainCommentType = $complaintCommentsModal.find('#appeal-comments-types'),
      $complaintModalTip = $complaintCommentsModal.find('.callback-msg'),
      $complaintCommentsContent = $complaintCommentsModal.find('.appeal-reason'),
      $complaintCommentBtn = $complaintCommentsModal.find('#complaint-comment-confirm'),
      complaintSending = false,
      initedCommentsType = false;
  
  function initCommentsTypeList() {
    if (!initedCommentsType) {
      $.ajax({
        url: "/appeals/fetch_types",
        method: 'get',
        data: {'type': 'comment'},
        success: function (data) {
          var result = '';
          for (var i = 0; i < data.length; i++) {
            result = result + "<div class='item' data-value='" + data[i].id + "'>" + data[i].name + "</div>";
          }
          $complainCommentType.find('.menu').html(result);
        }
      });
      $complainCommentType.dropdown({showOnFocus: false});
      initedCommentsType = true;
    }
  }
  $complainCommentType.on('click', function() {
    $complaintCommentsModal.modal({
      autofocus: false,
      onApprove: function() {
        return false;
      },
      onHidden: function() {
        restoreCommonentDefault();
      }
    }).modal('show');
  });
  
  $complaintCommentsContent.on('change keyup', function(e) {
    var content = $(this).val();
    if ($.trim(content).length > 0 && $complainCommentType.dropdown('get value').length > 0 ) {
      $complaintCommentBtn.removeClass('disabled');
      return;
    }
    $complaintCommentBtn.addClass('disabled');
  });
  
  
  $complainCommentType.dropdown({
    showOnFocus: false,
    onChange: function(value, text, $selectedItem) {
      if (value.length > 0 && $.trim($complaintCommentsContent.val()).length > 0) {
        $complaintCommentBtn.removeClass('disabled');
        return
      }
      $complaintCommentBtn.addClass('disabled');
    }
  });
  
  function restoreCommonentDefault() {
    $complainCommentType.dropdown('restore defaults');
    $complaintCommentsContent.val('');
    $('.exceeded-size-tip').text('').hide();
    $complaintModalTip.text('').hide();
    setTimeout(function() {
      setCommentSendTip(false);
    }, 1500);
  }
  
  $complaintCommentBtn.on('click',function(e){
    var reason = $complaintCommentsContent.val();
    var appealableId = $('#landing-comments-complaint-modal').attr('data-id');
    if (complaintSending) {
      return;
    }
    var appealType = $complainCommentType.dropdown('get value');
    var formData = new FormData();
    formData.append('appeal_type_id', appealType);
    formData.append('reason', reason);
    formData.append('appeal_type','Note');
    formData.append('target_id',appealableId);
    $.ajax({
      type: 'POST',
      url: "/appeals",
      cache: false,
      contentType: false,
      processData: false,
      data: formData,
      beforeSend: function() {
        setCommentSendStatus(true);
      },
      success: function(res) {
        if (res.status == 200) {
          setCommentSendTip(true);
          setTimeout(function() {
            $complaintCommentsModal.modal('hide');
            restoreCommonentDefault();
          }, 3000);
        }
        setCommentSendStatus(false);
      },
      error: function(err) {
        showCommonTips(err.responseJSON.message, 'error');
        setCommentSendStatus(false);
      }
    })
  });
  
  function showCommonTips(text, type) {
    $complaintModalTip.text(text).show();
    if (type == 'error') {
      $complaintModalTip.removeClass('success').addClass('error');
    } else {
      $complaintModalTip.removeClass('error').addClass('success');
    }
  }
  
  function setCommentSendStatus(value) {
    complaintSending = value;
    if (complaintSending) {
      $complaintCommentBtn.addClass('loading');
      $complaintCommentsContent.attr('readonly', true);
      $complainCommentType.attr('readonly', true);
    } else {
      $complaintCommentBtn.removeClass('loading');
      $complaintCommentsContent.attr('readonly', false);
      $complainCommentType.attr('readonly', false);
    }
  }
  
  function setCommentSendTip(value) {
    if (value) {
      $('.appeal-success-tip').removeClass('hide');
      $('.appeal-tip').addClass('hide');
      $('.appeal-form').addClass('hide');
      $('#landing-comments-complaint-modal .actions').addClass('hide');
    } else {
      $('.appeal-success-tip').addClass('hide');
      $('.appeal-tip').removeClass('hide');
      $('.appeal-form').removeClass('hide');
      $('#landing-comments-complaint-modal .actions').removeClass('hide');
    }
  }
</script>

</div>
<script>
  "use strict";
  $('.js-check-star').checkbox('set unchecked')
</script>

</div>
</div>
</div>
<div class='four wide column' style='display: none;'>
<div class='project__right-side'>
<div class='side-item intro'>
<div class='header'>
<h4>简介</h4>
<a class="ui link button pull-right btn-edit" href="javascript:void(0);"><i class='iconfont icon-edit'></i>
</a></div>
<div class='content'>
<span class='git-project-desc-text'>域名路由中间件可以控制不同的域名，来指向不同的静态资源目录，不需要在域名后面指定具体哪个目录。</span>
<a class='hide spread' href='javascript:void(0);'>
展开
<i class='caret down icon'></i>
</a>
<a class='retract hide' href='javascript:void(0);'>
收起
<i class='caret up icon'></i>
</a>
<div class='intro-list'>
<div class='blank d-flex d-flex-between dropdown item js-project-label_show label-list-line-feed project-label-list ui' data-labels='[]' data-url='/yzqc/DomainRouteMiddleware/update_description'>
<div class='mixed-label'>
</div>

<div class='default'>暂无标签</div>
<i class='iconfont icon-add-thin hover-color cursor-pointer'></i>
<div class='menu w100'>
<div class='ui input mt-1 mb-1 ml-1 mr-1'>
<input maxlength='35' placeholder='搜索或创建标签' type='text'>
</div>
<div class='scrolling menu'>
<div class='item d-none-important' data-is-related='0' data-value=''></div>
</div>
</div>
</div>
<div class='hide item'>
<i class='iconfont icon-link'></i>
<span class='git-project-homepage'>
<a rel="nofollow" id="homepage" target="_blank" href="/yzqc/DomainRouteMiddleware/blob/master/README.md">/yzqc/DomainRouteMiddleware/blob/master/README.md</a>
</span>
</div>

<div class='item'>
<i class='iconfont icon-licence'></i>
<a target="_blank" id="license-popup" href="/yzqc/DomainRouteMiddleware/blob/master/LICENSE">MIT</a>
<div class='ui popup dark'>使用 MIT 开源许可协议</div>
</div>
</div>
</div>
<div class='content intro-form'>
<div class='ui small input'>
<textarea name='project[description]' placeholder='描述' rows='5'></textarea>
</div>
<div class='ui small input'>
<input data-regex-value='(^$)|(^(http|https):\/\/(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5]).*)|(^(http|https):\/\/[a-zA-Z0-9]+([_\-\.]{1}[a-zA-Z0-9]+)*\.[a-zA-Z]{2,10}(:[0-9]{1,10})?(\?.*)?(\/.*)?$)' name='project[homepage]' placeholder='主页(eg: https://gitee.com)' type='text'>
</div>
<button class='ui orange button mt-1 btn-save'>
保存更改
</button>
<div class='ui blank button btn-cancel-edit'>
取消
</div>
</div>
</div>
<div class='side-item release'>
<div class='header'>
<h4>发行版</h4>
</div>
<div class='content'>
<span class='text-muted'>
暂无发行版，
<a href="/yzqc/DomainRouteMiddleware/releases/new">创建</a>
</span>
</div>
</div>
<div class='side-item contrib' data-url='/yzqc/DomainRouteMiddleware/contributors_count?ref=master' id='contributor'>
<div class='header'>
<h4>
贡献者
<span class='text-muted' id='contributor-count'></span>
</h4>
<a class="ui link button pull-right" href="/yzqc/DomainRouteMiddleware/contributors?ref=master">全部</a>
</div>
<div class='content' id='contributor-list'></div>
<div class='ui active centered inline loader' id='contributor-loader'></div>
</div>
<div class='side-item events' data-url='/yzqc/DomainRouteMiddleware/events.json' id='proj-events'>
<div class='header'>
<h4>近期动态</h4>
</div>
<div class='content'>
<div class='ui comments' id='event-list'></div>
<a class="loadmore hide" href="javascript:void(0);">加载更多
<i class='icon dropdown'></i>
</a><center>
<div class='text-muted nomore hide'>不能加载更多了</div>
<div class='ui inline loader active'></div>
</center>
</div>
</div>
</div>
<div class='ui modal tiny' id='edit-project-description'>
<i class='iconfont icon-close close'></i>
<div class='header'>编辑仓库简介</div>
<div class='content'>
<div class='item mb-2'>
<div class='title label'>简介内容</div>
<div class='ui small input'>
<textarea maxlength='200' name='project[description]' placeholder='描述' rows='5'>域名路由中间件可以控制不同的域名，来指向不同的静态资源目录，不需要在域名后面指定具体哪个目录。</textarea>
</div>
</div>
<div class='item mb-2'>
<div class='title label'>主页</div>
<div class='ui small input'>
<input data-regex-value='(^$)|(^(http|https):\/\/(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5]).*)|(^(http|https):\/\/[a-zA-Z0-9]+([_\-\.]{1}[a-zA-Z0-9]+)*\.[a-zA-Z]{2,10}(:[0-9]{1,10})?(\?.*)?(\/.*)?$)' name='project[homepage]' placeholder='主页(eg: https://gitee.com)' type='text'>
</div>
</div>
</div>
<div class='actions'>
<button class='ui button blank cancel'>取消</button>
<button class='ui button orange btn-save'>保存更改</button>
</div>
</div>

<script>
  window.gon.projectRightSide = {
    homepage: null,
    description: "域名路由中间件可以控制不同的域名，来指向不同的静态资源目录，不需要在域名后面指定具体哪个目录。",
    url: '/yzqc/DomainRouteMiddleware/update_description',
    i18n: {
      invalidHomepage: '不是有效的 http 地址',
      descriptionLimitExceeded: '简介长度不得超过%{limit}个字符',
      noDescription: '暂无描述',
      noPermission: '无权限操作！',
      requestError: '修改发生错误，请稍后重试！'
    }
  }
  window.gon.cloneArrSelectedLabel = [] || []
  $(function () {
    var $editModal = $('#edit-project-description')
    $editModal.modal({
      onShow: function () {
        window.globalUtils.getFocus($editModal.find('textarea'))
      }
    })
    $('.project__right-side').on('click', '.header .btn-edit', function () {
      $editModal.modal('show')
    })
    $('#license-popup').popup({ position: 'bottom center', lastResort: 'bottom center' })
  
    $('.js-project-label_show').projectLabel({
      i18n: {
        empty: "标签名不能为空",
        verify: "标签名只允许包含中文、字母、数字或者中划线(-)，不能以中划线开头，且长度少于35个字符",
        max: "最多选择 5 个标签"
      }
    })
  })
</script>

</div>
</div>
</div>
<script>
  (function() {
    $(function() {
      Tree.init();
      return TreeCommentActions.init();
    });
  
  }).call(this);
</script>

</div>
<script>
  (function() {
    var donateModal;
  
    Gitee.modalHelper = new GiteeModalHelper({
      alertText: '提示',
      okText: '确定'
    });
  
    donateModal = new ProjectDonateModal({
      el: '#project-donate-modal',
      alipayUrl: '/yzqc/DomainRouteMiddleware/alipay',
      wepayUrl: '/yzqc/DomainRouteMiddleware/wepay',
      nameIsBlank: '名称不能为空',
      nameTooLong: '名称过长（最多为 36 个字符）',
      modalHelper: Gitee.modalHelper
    });
  
    if (null === 'true') {
      donateModal.show();
    }
  
    $('#project-donate').on('click', function() {
      return donateModal.show();
    });
  
  }).call(this);
</script>
<script>
  Tree.initHighlightTheme('white')
</script>


</div>
<div class='gitee-project-extension'>
<div class='extension public'>1</div>
<div class='extension https'>https://gitee.com/yzqc/DomainRouteMiddleware.git</div>
<div class='extension ssh'>git@gitee.com:yzqc/DomainRouteMiddleware.git</div>
<div class='extension namespace'>yzqc</div>
<div class='extension repo'>DomainRouteMiddleware</div>
<div class='extension name'>DomainRouteMiddleware</div>
<div class='extension branch'>master</div>
</div>

<script>
  $(function() {
    GitLab.GfmAutoComplete.dataSource = "/yzqc/DomainRouteMiddleware/autocomplete_sources"
    GitLab.GfmAutoComplete.Emoji.assetBase = '/assets/emoji'
    GitLab.GfmAutoComplete.setup();
  });
</script>

<footer id='git-footer-main'>
<div class='ui container'>
<div class='logo-row'>
<img class='logo-img' src='/static/images/logo-black.svg?t=158106666'>
</div>
<div class='name-important'>
深圳市奥思网络科技有限公司版权所有
</div>
<div class='ui two column grid d-flex-center'>
<div class='nine wide column git-footer-left'>
<div class='ui four column grid' id='footer-left'>
<div class='column'>
<div class='ui link list'>
<div class='item'>
<a class="item" href="/all-about-git">Git 大全</a>
</div>
<div class='item'>
<a class="item" href="https://oschina.gitee.io/learn-git-branching/">Git 命令学习</a>
</div>
<div class='item'>
<a class="item" href="https://copycat.gitee.com/">CopyCat 代码克隆检测</a>
</div>
<div class='item'>
<a class="item" href="/appclient">APP与插件下载</a>
</div>
</div>
</div>
<div class='column'>
<div class='ui link list'>
<div class='item'>
<a class="item" href="/gitee_reward">Gitee Reward</a>
</div>
<div class='item'>
<a class="item" href="/gitee-stars">Gitee 封面人物</a>
</div>
<div class='item'>
<a class="item" href="/gvp">GVP 项目</a>
</div>
<div class='item'>
<a class="item" href="https://blog.gitee.com/">Gitee 博客</a>
</div>
<div class='item'>
<a class="item" href="/enterprises#nonprofit-plan">Gitee 公益计划</a>
</div>
</div>
</div>
<div class='column'>
<div class='ui link list'>
<div class='item'>
<a class="item" href="/api/v5/swagger">OpenAPI</a>
</div>
<div class='item'>
<a class="item" href="/help">帮助文档</a>
</div>
<div class='item'>
<a class="item" href="/self_services">在线自助服务</a>
</div>
<div class='item'>
<a class="item" href="/help/articles/4338#article-header0">更新日志</a>
</div>
</div>
</div>
<div class='column'>
<div class='ui link list'>
<div class='item'>
<a class="item" href="/about_us">关于我们</a>
</div>
<div class='item'>
<a class="item" href="https://www.oschina.net/news/131099/oschina-hiring">加入我们</a>
</div>
<div class='item'>
<a class="item" href="/terms">使用条款</a>
</div>
<div class='item'>
<a class="item" href="/oschina/git-osc/issues">意见建议</a>
</div>
<div class='item'>
<a class="item" href="/links.html">合作伙伴</a>
</div>
</div>
</div>
</div>
</div>
<div class='seven wide column right aligned followus git-footer-right'>
<div class='qrcode mini_app'>
<img src="https://assets.gitee.com/assets/mini_app-e5eee5a21c552b69ae6bf2cf87406b59.jpg" alt="Mini app" />
<p class='mini_app-text'>微信小程序</p>
</div>
<div class='qrcode weixin'>
<img src="https://assets.gitee.com/assets/qrcode-weixin-9e7cfb27165143d2b8e8b268a52ea822.jpg" alt="Qrcode weixin" />
<p class='weixin-text'>微信服务号</p>
</div>
<div class='phone-and-qq column'>
<div class='ui list official-support-container'>
<div class='item'>
<a class="icon-popup" title="点击加入 Gitee 官方群" href="//qm.qq.com/cgi-bin/qm/qr?k=OUfztMuf7jElTIf78lMuNT_D_lZYOWnd"><i class='iconfont icon-logo-qq'></i>
<span>官方技术交流QQ群：515965326</span>
</a></div>
<div class='item mail-and-zhihu'>
<a href="mailto: git@oschina.cn"><i class='iconfont icon-msg-mail'></i>
<span id='git-footer-email'>git#oschina.cn</span>
</a></div>
<div class='item mail-and-zhihu'>
<a target="_blank" href="https://www.zhihu.com/org/ma-yun-osc/"><i class='iconfont icon-zhihu'></i>
<span>Gitee</span>
</a></div>
<div class='item tel'>
<a>
<i class='iconfont icon-tel'></i>
<span>售前及售后使用咨询：400-606-0201</span>
</a>
</div>
</div>
</div>
</div>
</div>
</div>
<div class='bottombar'>
<div class='ui container'>
<div class='ui d-flex d-flex-between'>
<div class='seven wide column partner d-flex'>
<div class='open-atom d-flex-center'>
<img class="logo-openatom mr-1" src="https://assets.gitee.com/assets/logo-openatom-d083391cc8a54e283529f3fc11cc38ca.svg" alt="Logo openatom" />
<a target="_blank" href="https://www.openatom.org/">开放原子开源基金会</a>
<div class='sub-title ml-1'>合作代码托管平台</div>
</div>
<div class='report-12377 d-flex-center ml-3'>
<img class="report-12377__logo mr-1" src="https://assets.gitee.com/assets/12377@2x-1aa42ed2d2256f82a61ecf57be1ec244.png" alt="12377@2x" />
<a target="_blank" href="https://12377.cn">违法和不良信息举报中心</a>
</div>
<div class='copyright ml-3'>
<a href="http://beian.miit.gov.cn/">粤ICP备12009483号</a>
</div>
</div>
<div class='nine wide column right aligned'>
<i class='icon world'></i>
<a href="/language/zh-CN">简 体</a>
/
<a href="/language/zh-TW">繁 體</a>
/
<a href="/language/en">English</a>
</div>
</div>
</div>
</div>
</footer>
<script>
  var officialEmail = $('#git-footer-email').text()
  $('#git-footer-main .icon-popup').popup({ position: 'bottom center' })
  $('#git-footer-email').text(officialEmail.replace('#', '@'))
  window.gon.popover_card_locale = {
    follow:"关注",
    unfollow:"已关注",
    gvp_title: "GVP - Gitee 最有价值开源项目",
    project: "项目",
    org: "开源组织",
    member: "",
    author: "作者",
    user_blocked: "该用户已被屏蔽或已注销",
    net_error: "网络错误",
    unknown_exception: "未知异常"
  }
  window.gon.select_message = {
    placeholder: "请输入个人空间地址或完整的邮箱地址"
  }
</script>
<script src="https://assets.gitee.com/webpacks/popover_card-a11f191f82a7fff418c3.bundle.js"></script>
<link rel="stylesheet" media="all" href="https://assets.gitee.com/webpacks/css/gitee_nps-86d53fceeff4ca14045b.css" />
<script src="https://assets.gitee.com/webpacks/gitee_nps-e5d2e62f64e4bdf2e267.bundle.js"></script>


<div class='side-toolbar'>
<div class='button toolbar-help'>
<i class='iconfont icon-help'></i>
</div>
<div class='ui popup left center dark'>点此查找更多帮助</div>
<div class='toolbar-help-dialog'>
<div class='toolbar-dialog-header'>
<h3 class='toolbar-dialog-title'>搜索帮助</h3>
<form class="toolbar-help-search-form" action="/help/load_keywords_data" accept-charset="UTF-8" method="get"><input name="utf8" type="hidden" value="&#x2713;" />
<div class='ui icon input fluid toolbar-help-search'>
<input name='keywords' placeholder='请输入产品名称或问题' type='text'>
<i class='icon search'></i>
</div>
</form>

<i class='iconfont icon-close toolbar-dialog-close-icon'></i>
</div>
<div class='toolbar-dialog-content'>
<div class='toolbar-help-hot-search'>
<div class='toolbar-roll'>
<a class="init active" title="Git 命令在线学习" href="https://oschina.gitee.io/learn-git-branching/?utm_source==gitee-help-widget"><i class='Blue icon icon-command iconfont'></i>
<span>Git 命令在线学习</span>
</a><a class="init " title="如何在 Gitee 导入 GitHub 仓库" href="https://gitee.com/help/articles/4261?utm_source==gitee-help-widget"><i class='icon icon-clipboard iconfont orange'></i>
<span>如何在 Gitee 导入 GitHub 仓库</span>
</a></div>
<div class='toolbar-list'>
<div class='toolbar-list-item'>
<a href="/help/articles/4114">Git 仓库基础操作</a>
</div>
<div class='toolbar-list-item'>
<a href="/help/articles/4166">企业版和社区版功能对比</a>
</div>
<div class='toolbar-list-item'>
<a href="/help/articles/4191">SSH 公钥设置</a>
</div>
<div class='toolbar-list-item'>
<a href="/help/articles/4194">如何处理代码冲突</a>
</div>
<div class='toolbar-list-item'>
<a href="/help/articles/4232">仓库体积过大，如何减小？</a>
</div>
<div class='toolbar-list-item'>
<a href="/help/articles/4279">如何找回被删除的仓库数据</a>
</div>
<div class='toolbar-list-item'>
<a href="/help/articles/4283">Gitee 产品配额说明</a>
</div>
<div class='toolbar-list-item'>
<a href="/help/articles/4284">GitHub仓库快速导入Gitee及同步更新</a>
</div>
<div class='toolbar-list-item'>
<a href="/help/articles/4328">什么是 Release（发行版）</a>
</div>
<div class='toolbar-list-item'>
<a href="/help/articles/4354">将 PHP 项目自动发布到 packagist.org</a>
</div>
</div>
</div>
<div class='toolbar-help-search-reseult'>
<div class='toolbar-help-flex-column'>
<div class='ui centered inline loader toolbar-help-loader'></div>
<div class='toolbar-list'></div>
<div class='toolbar-help-link-to-help'>
<a target="_blank" href="">查看更多搜索结果</a>
</div>
</div>
</div>
</div>
</div>
<script>
  var opt = { position: 'left center'};
  var $helpSideToolbar = $('.button.toolbar-help');
  var $toolbarRoll = $('.toolbar-roll');
  
  $(function() {
    if (true) {
      $helpSideToolbar.popup(opt).popup({lastResort:'left center'})
    } else {
      $helpSideToolbar.popup({lastResort:'left center'}).popup('show', opt);
      setTimeout(function() {
        $helpSideToolbar.popup('hide', opt);
      }, 3000);
    }
  
    if ($toolbarRoll.length) {
      setInterval(function() {
        var $nextActiveLink = $toolbarRoll.find('a.active').next();
        if (!$nextActiveLink.length) {
          $nextActiveLink = $toolbarRoll.find('a:first-child');
        }
        $nextActiveLink.attr('class', 'active').siblings().removeClass('active init');
      }, 5000);
    }
  })
</script>

<div class='ui popup dark left center transition hidden js-feedback-popup'>发送反馈</div>
<div class='button' id='feedback-btn'>
<i class='iconfont icon-feedback'></i>
</div>
<div class='button share-link'>
<i class='iconfont icon-share'></i>
</div>
<div class='ui popup dark'>
<div class='header'>
分享到
</div>
<div class='bdsharebuttonbox' style='display: flex'>
<a class='iconfont icon-home-service-wechat' data-cmd='weixin' title='分享到微信'></a>
<a class='iconfont icon-weibo' data-cmd='tsina' title='分享到新浪微博'></a>
<a class='iconfont icon-qq' data-cmd='sqq' title='分享到QQ好友'></a>
<a class='iconfont icon-qzone' data-cmd='qzone' title='分享到QQ空间'></a>
</div>
</div>
<div class='popup button' id='home-comment'>
<i class='iconfont icon-comment'></i>
</div>
<div class='ui popup dark'>评论</div>
<div class='button gotop popup' id='gotop'>
<i class='iconfont icon-top'></i>
</div>
<div class='ui popup dark'>回到顶部</div>
</div>
<style>
  .side-toolbar .bdsharebuttonbox a {
    font-size: 24px;
    color: white !important;
    opacity: 0.9;
    margin: 6px 6px 0px 6px;
    background-image: none;
    text-indent: 0;
    height: auto;
    width: auto;
  }
</style>
<style>
  #udesk_btn a {
    margin: 0px 20px 267px 0px !important;
  }
</style>
<script>
  (function() {
    $('#project-user-message').popup({
      position: 'left center'
    });
  
  }).call(this);
</script>
<script>
  Gitee.initSideToolbar({
    hasComment: true,
    commentUrl: '/yzqc/DomainRouteMiddleware#tree_comm_title'
  })
</script>
<script>
  window._bd_share_config = {
    "common": {
      "bdSnsKey": {},
      "bdText": document.title,
      "bdMini": "1",
      "bdMiniList": ["bdxc","tqf","douban","bdhome","sqq","thx","ibaidu","meilishuo","mogujie","diandian","huaban","duitang","hx","fx","youdao","sdo","qingbiji","people","xinhua","mail","isohu","yaolan","wealink","ty","iguba","fbook","twi","linkedin","h163","evernotecn","copy","print"],
      "bdPic": "",
      "bdStyle": "1",
      "bdSize": "32"
    },
    "share": {}
  }
</script>
<script src="/bd_share/static/api/js/share.js"></script>
<link rel="stylesheet" media="all" href="https://assets.gitee.com/webpacks/css/side_toolbar_feedback-7e09f46182ec5f6f4e00.css" />
<script src="https://assets.gitee.com/webpacks/side_toolbar_feedback-92100b5dab1bc6cd62c3.bundle.js"></script>





<script>
  (function() {
    this.__gac = {
      domain: 'www.oschina.net'
    };
  
  }).call(this);
</script>

</body>
</html>

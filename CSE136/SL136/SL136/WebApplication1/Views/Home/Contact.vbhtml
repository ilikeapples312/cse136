﻿@Code
    ViewData("Title") = "Contact"
End Code

<hgroup class="title">
    <h2>@ViewData("Title").</h2>
    <h3>@ViewData("Message")</h3>
</hgroup>
<div>
    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <address>
        <i class="icon-envelope"></i><strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <i class="icon-envelope"></i><strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</div>

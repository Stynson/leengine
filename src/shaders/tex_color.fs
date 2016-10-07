$input v_color0, v_texcoord0

#include <bgfx_shader.sh>

SAMPLER2D(u_texture, 0);

void main()
{
	gl_FragColor = vec4(texture2D(u_texture, v_texcoord0).rgba) * v_color0;
}

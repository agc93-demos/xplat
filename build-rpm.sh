#!/usr/bin/env bash

docker run -it --rm -w /out -v /tmp/rpm:/out -v $PWD/out:/app:ro tenzer/fpm:latest -s dir -a x86_64 --force -m 'Alistair Chapman <alistair@agchapman.com>' -n 'xplat' -v 0.0.1 -t rpm -d libunwind -d libicu /app/=/usr/lib/xplat/